using System.Windows.Forms;
using System;
using PetMate_Shop.Views;
using System.Data.SqlClient;
using PetMate_Shop.Database;
using PetMate_Shop.ComponentForms;
using PetMate_Shop.Models;

namespace PetMate_Shop.ComponentCarts
{
    public partial class AdopRequstCard : UserControl
    {
        private string _descriptionValue;
        private string _emailValue;
        private string _phoneValue;
        private string _cityAreaNameValue;
        private string _petIdValue;
        private string _customerIdValue;
        private string _requestDate;
        private string _adoptionID;

        public AdopRequstCard(
            string adoptionID,
            string descriptionValue,
            string emailValue,
            string phoneValue,
            string cityAreaNameValue,
            string petIdValue,
            string customerIdValue,
            string requestDate)
        {
            InitializeComponent();
            _descriptionValue = descriptionValue;
            _emailValue = emailValue;
            _phoneValue = phoneValue;
            _cityAreaNameValue = cityAreaNameValue;
            _petIdValue = petIdValue;
            _customerIdValue = customerIdValue;
            _requestDate = requestDate;
            _adoptionID = adoptionID;

            LoadData();
        }

        private void LoadData()
        {
            discriptionValue.Text = _descriptionValue;
            emailValueLabel.Text = _emailValue;
            phoneValueLabel.Text = _phoneValue;
            cityAreaNameValueLabel.Text = _cityAreaNameValue;
            petIdValue.Text = _petIdValue;
            customerIdValueLabel.Text = _customerIdValue;
            requestDateLabel.Text = _requestDate;
        }

        private void AcceptRequestBtn_Click(object sender, EventArgs e)
        {
            string userName = MainForm.instance._userName;
            string customerId = null;

            var connection = DatabaseConnection.GetConnection();
            try
            {
                connection.Open();
                string getCustomerIdQuery = "SELECT CustomerID FROM Customer WHERE UserName = @UserName";
                SqlCommand command = new SqlCommand(getCustomerIdQuery, connection);
                command.Parameters.AddWithValue("@UserName", userName);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    customerId = reader["CustomerID"].ToString();
                }
                reader.Close();
                command.Dispose();

                if (string.IsNullOrEmpty(customerId))
                {
                    MessageBox.Show("Customer not found for the logged-in user.");
                    return;
                }

                MessageBox.Show($"CustomerID: {customerId}, PetID: {_petIdValue}");

                string updateAdoptionQuery = @"
                                                UPDATE Adoption 
                                                SET AcceptanceStatus = 'accepted' 
                                                WHERE AdoptionID = @adoptionID AND PetID = @PetID";

                command = new SqlCommand(updateAdoptionQuery, connection);
                command.Parameters.AddWithValue("@adoptionID", _adoptionID.Trim());
                command.Parameters.AddWithValue("@PetID", _petIdValue.Trim());
                int rowsAffected = command.ExecuteNonQuery();
                command.Dispose();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("No rows updated in the Adoption table. Check your CustomerID and PetID values.");
                    return;
                }

                string updateBuyPetQuery = @"
                                            UPDATE BuyPet 
                                            SET AdoptedBy = @CustomerID 
                                            WHERE PetID = @PetID";

                command = new SqlCommand(updateBuyPetQuery, connection);
                command.Parameters.AddWithValue("@CustomerID", customerId.Trim());
                command.Parameters.AddWithValue("@PetID", _petIdValue.Trim());
                rowsAffected = command.ExecuteNonQuery();
                command.Dispose();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("No rows updated in the BuyPet table. Check your PetID value.");
                    return;
                }

                AdoptionForm.instance.LoadCard();
                MessageBox.Show("Adoption request accepted successfully.");
                MakeNotification.AddNotification(MainForm.instance._userName, "Someone has accepted your adoption request");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            connection.Dispose();
        }

        private void AdopRequstCard_Load(object sender, EventArgs e)
        {

        }
    }
}
