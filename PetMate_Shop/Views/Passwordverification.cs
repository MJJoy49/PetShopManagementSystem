using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class Passwordverification : Form
    {
        private string _customerId;
        private bool _isVerified;

        public Passwordverification(string customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }

        public bool IsVerified
        {
            get { return _isVerified; }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            string enteredPassword = passwordTB.Text;

            if (string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter your password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string query = @"
                        SELECT u.Password
                        FROM Users u
                        INNER JOIN Customer c ON u.UserName = c.UserName
                        WHERE c.CustomerID = @CustomerID";

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", _customerId);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string storedPassword = reader["Password"].ToString();

                    if (storedPassword == enteredPassword)
                    {
                        _isVerified = true;
                        MessageBox.Show("Password verified successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordTB.UseSystemPasswordChar = !passwordTB.UseSystemPasswordChar;
        }
    }
}
