using PetMate_Shop.Database;
using PetMate_Shop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetMate_Shop.Views
{
    public partial class HelpRequest : Form
    {
        string _volunteerIdValue;
        string _petId;
        string _customerId;
        string _userName;

        public HelpRequest(string volunteerIdValue)
        {
            InitializeComponent();
            _volunteerIdValue = volunteerIdValue;
            _userName = MainForm.instance._userName;
            getCustomerId(_userName);
            MessageBox.Show(_customerId);
        }

        private void getCustomerId(string userName)
        {
            string query = @"
                        SELECT 
                            CustomerID
                        FROM 
                            Customer
                        WHERE 
                            UserName = @UserName";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    _customerId = reader["CustomerID"].ToString();
                }

                reader.Close();
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendRequestBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(petIdTB.Text) || string.IsNullOrEmpty(descriptionText.Text))
            {
                MessageBox.Show("Please provide the Pet ID and Description.");
                return;
            }

            if (!PetValidity(petIdTB.Text.Trim()))
            {
                MessageBox.Show("This pet is not purchased by the customer.");
                return;
            }

            string helpRequestId = IdCreator.GenerateId("HelpRequest", "HP", 3, 2);

            string query = @"
                        INSERT INTO HelpRequest
                        (HelpRequestID, CustomerID, PetID, VolunteerID, HelpDescription, Status)
                        VALUES
                        (@HelpRequestID, @CustomerID, @PetID, @VolunteerID, @HelpDescription, @Status)";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HelpRequestID", helpRequestId);
                command.Parameters.AddWithValue("@CustomerID", _customerId);
                command.Parameters.AddWithValue("@PetID", petIdTB.Text.Trim());
                command.Parameters.AddWithValue("@VolunteerID", _volunteerIdValue);
                command.Parameters.AddWithValue("@HelpDescription", descriptionText.Text.Trim());
                command.Parameters.AddWithValue("@Status", "not accepted");

                command.ExecuteNonQuery();

                MessageBox.Show("Help request sent successfully.");
                this.Close();

                command.Dispose();
                connection.Dispose();

                MakeNotification.AddNotification(_volunteerIdValue, "A customer has sent you a help request");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private bool PetValidity(string petId)
        {
            bool isValid = false;
            string query = @"
                        SELECT 
                            COUNT(*) 
                        FROM 
                            BuyPet 
                        WHERE 
                            CustomerID = @CustomerID AND PetID = @PetID";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", _customerId);
                command.Parameters.AddWithValue("@PetID", petId);

                var reader = command.ExecuteReader();
                if (reader.Read() && Convert.ToInt32(reader[0]) > 0)
                {
                    isValid = true;
                }

                reader.Close();
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return isValid;
        }
    }
}
