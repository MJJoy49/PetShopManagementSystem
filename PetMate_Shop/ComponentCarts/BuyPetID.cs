using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using PetMate_Shop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetMate_Shop.ComponentCarts
{
    public partial class BuyPetID : UserControl
    {
        string _petIdValue;
        string _puschaseValueLabel;
        string _adoptedValueLabel;
        string _userID;
        public BuyPetID(string petIdValue, string puschaseDate, string adoptedValue, string userID)
        {
            InitializeComponent();

            _petIdValue = petIdValue;
            _puschaseValueLabel = puschaseDate;
            _adoptedValueLabel = adoptedValue;
            _userID = userID;
            updata();
        }

        public void updata()
        {
            petIdValueLabel.Text = _petIdValue;
            puschaseValueLabel.Text = _puschaseValueLabel;
            adoptedValueLabel.Text = _adoptedValueLabel;

            if (_adoptedValueLabel == "No adopted")
            {
                adoptionRequestBtn.Text = "Adoption Request";
            }
            else
            {
                adoptionRequestBtn.Text = "Adopter details";
            }
        }

        private void adoptionRequestBtn_Click(object sender, EventArgs e)
        {
            if (adoptionRequestBtn.Text == "Adoption Request")
            {
                AdoptionRequest adoptionRequest = new AdoptionRequest(_petIdValue, _userID);
                adoptionRequest.Show();
            }
            else
            {
                getAdopterInfo();
            }
        }

        private void getAdopterInfo()
        {
            string getCustomerQuery = "SELECT UserName FROM Customer WHERE CustomerID = @CustomerID";
            string getUserDetailsQuery = @"
                                            SELECT 
                                                Users.Email, 
                                                Users.Phone, 
                                                Users.HouseOrBuildingOrFlatNumber, 
                                                Users.StreetNameOrNumber, 
                                                Users.CityOrAreaName, 
                                                Users.PostalCode
                                            FROM Users
                                            INNER JOIN Customer ON Customer.UserName = Users.UserName
                                            WHERE Customer.CustomerID = @CustomerID";

            var connection = DatabaseConnection.GetConnection();
            try
            {
                connection.Open();

                string userName = string.Empty;
                SqlCommand getCustomerCommand = new SqlCommand(getCustomerQuery, connection);
                getCustomerCommand.Parameters.AddWithValue("@CustomerID", _adoptedValueLabel);
                SqlDataReader reader = getCustomerCommand.ExecuteReader();

                if (reader.Read())
                {
                    userName = reader["UserName"].ToString();
                }
                reader.Close();
                getCustomerCommand.Dispose();

                if (!string.IsNullOrEmpty(userName))
                {
                    SqlCommand getUserDetailsCommand = new SqlCommand(getUserDetailsQuery, connection);
                    getUserDetailsCommand.Parameters.AddWithValue("@CustomerID", _adoptedValueLabel);
                    reader = getUserDetailsCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        string email = reader["Email"].ToString();
                        string phone = reader["Phone"].ToString();
                        string house = reader["HouseOrBuildingOrFlatNumber"].ToString();
                        string street = reader["StreetNameOrNumber"].ToString();
                        string city = reader["CityOrAreaName"].ToString();
                        string postalCode = reader["PostalCode"].ToString();

                        string details = $"╔════════════════════════════════════════╗\n                       **Adopter Details**        \n╚════════════════════════════════════════╝\n\nEmail       : {email}\nPhone       : {phone}\n\nAddress Details:\n  House      : {house}\n  Street     : {street}\n  City       : {city}\n  Postal Code: {postalCode}\n";

                        MessageBox.Show(details, "Adopter Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Adopter details not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    reader.Close();
                    getUserDetailsCommand.Dispose();
                }
                else
                {
                    MessageBox.Show("Customer not found for the given ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Dispose();
        }
    }
}
