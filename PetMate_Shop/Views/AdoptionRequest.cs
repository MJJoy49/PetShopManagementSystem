using PetMate_Shop.Database;
using PetMate_Shop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class AdoptionRequest : Form
    {
        string _petID;
        string _customerID;

        public AdoptionRequest(string petId, string customerId)
        {
            InitializeComponent();
            _petID = petId;
            _customerID = customerId;

            SetupForm();
        }

        void SetupForm()
        {
            if (petIdValue != null)
            {
                petIdValue.Text = _petID;
            }
            else
            {
                MessageBox.Show("petIdValue control is not initialized.");
            }
        }

        private void sendRequestBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(descriptionText.Text))
            {
                string adoptionID = IdCreator.GenerateId("Adoption", "ADOP", 3, 2);
                string customerId = _customerID;
                DateTime requestDate = DateTime.Now;
                string acceptanceStatus = "not accepted";
                string description = descriptionText.Text;

                string query = "INSERT INTO Adoption (AdoptionID, PetID, CustomerID, RequestDate, AcceptanceStatus, Description) " +
                               "VALUES (@AdoptionID, @PetID, @CustomerID, @RequestDate, @AcceptanceStatus, @Description)";

                var connection = DatabaseConnection.GetConnection();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AdoptionID", adoptionID);
                command.Parameters.AddWithValue("@PetID", _petID);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                command.Parameters.AddWithValue("@RequestDate", requestDate);
                command.Parameters.AddWithValue("@AcceptanceStatus", acceptanceStatus);
                command.Parameters.AddWithValue("@Description", description);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Adoption request sent successfully.");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                command.Dispose();
                connection.Dispose();
            }
            else
            {
                MessageBox.Show("Description cannot be empty.");
            }
        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
