using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class EditCustomer : Form
    {
        string _email;
        string _name;
        string _phoneNumber;
        string _cityOrAreaName;
        string _password;
        string _totalPurchaseValue;
        string _totalPetBuyValue;
        string _customerIdValue;
        string _userName;
        UsersForm _recall;

        public EditCustomer(
            string totalPurchaseValue,
            string totalPetBuyValue,
            string customerIdValue,
            string userName,
            UsersForm recall
        )
        {
            InitializeComponent();
            _customerIdValue = customerIdValue;
            _userName = userName;
            _recall = recall;
            _totalPurchaseValue = totalPurchaseValue;
            _totalPetBuyValue = totalPetBuyValue;

            showData();
        }

        void showData()
        {
            string query = @"
                SELECT 
                    Name, 
                    Email, 
                    Phone, 
                    CityOrAreaName, 
                    Password 
                FROM Users 
                WHERE UserName = @UserName";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", _userName);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    _name = reader["Name"].ToString();
                    _email = reader["Email"].ToString();
                    _phoneNumber = reader["Phone"].ToString();
                    _cityOrAreaName = reader["CityOrAreaName"].ToString();
                    _password = reader["Password"].ToString();
                }

                reader.Close();
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            nameTB.Text = _name;
            emailTB.Text = _email;
            phoneNumberTB.Text = _phoneNumber;
            cityOrAreaNameTB.Text = _cityOrAreaName;
            userNameTB.Text = _userName;
            passwordTB.Text = _password;
            totalPurchaseValue.Text = $"{_totalPurchaseValue} tk";
            totalPetBuyValue.Text = _totalPetBuyValue;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditCustomerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTB.Text) ||
                string.IsNullOrEmpty(emailTB.Text) ||
                string.IsNullOrEmpty(phoneNumberTB.Text) ||
                string.IsNullOrEmpty(passwordTB.Text) ||
                string.IsNullOrEmpty(cityOrAreaNameTB.Text))
            {
                MessageBox.Show("Please fill in all the fields before updating the Customer details.");
                return;
            }

            string query = @"
                UPDATE Users
                SET Name = @Name, 
                    Email = @Email, 
                    Phone = @Phone, 
                    CityOrAreaName = @CityOrAreaName, 
                    Password = @Password, 
                    UpdatedAt = GETDATE()
                WHERE UserName = @UserName";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", nameTB.Text);
                command.Parameters.AddWithValue("@Email", emailTB.Text);
                command.Parameters.AddWithValue("@Phone", phoneNumberTB.Text);
                command.Parameters.AddWithValue("@CityOrAreaName", cityOrAreaNameTB.Text);
                command.Parameters.AddWithValue("@Password", passwordTB.Text);
                command.Parameters.AddWithValue("@UserName", _userName);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _recall.LoadCustomers();
                }
                else
                {
                    MessageBox.Show("No data was updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveCustomerBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                string deleteQuery = @"
                    DELETE FROM Customer WHERE CustomerID = @CustomerID;
                    DELETE FROM Users WHERE UserName = @UserName;";

                try
                {
                    var connection = DatabaseConnection.GetConnection();
                    connection.Open();
                    var command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@CustomerID", _customerIdValue);
                    command.Parameters.AddWithValue("@UserName", _userName);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Customer data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _recall.LoadCustomers();
                    this.Hide();

                    command.Dispose();
                    connection.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
