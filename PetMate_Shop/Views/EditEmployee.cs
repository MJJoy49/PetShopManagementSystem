using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class EditEmployee : Form
    {
        string _hireDateValue;
        string _password;
        string _salary;
        string _name;
        string _cityOrAreaName;
        string _phoneNumber;
        string _email;
        string _userName;
        string _employeeIdValue;
        UsersForm _recall;

        public EditEmployee(UsersForm recall, string hireDateValue, string userName, string salary, string employeeIdValue)
        {
            InitializeComponent();

            _recall = recall;
            _hireDateValue = hireDateValue;
            _userName = userName;
            _salary = salary;
            _employeeIdValue = employeeIdValue;

            showData();
        }

        void showData()
        {
            hireDateValue.Text = _hireDateValue;
            salaryTB.Text = _salary;
            userNameTB.Text = _userName;
            employeeIdValue.Text = _employeeIdValue;

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string query = "SELECT * FROM Users WHERE UserName = @UserName";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", _userName);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    passwordTB.Text = reader["Password"].ToString();
                    nameTB.Text = reader["Name"].ToString();
                    cityOrAreaNameTB.Text = reader["CityOrAreaName"].ToString();
                    phoneNumberTB.Text = reader["Phone"].ToString();
                    emailTB.Text = reader["Email"].ToString();
                }

                reader.Close();
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the data: {ex.Message}");
            }
        }

        private void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(salaryTB.Text) || string.IsNullOrEmpty(userNameTB.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string updateUserQuery = @"
                        UPDATE Users 
                        SET 
                            Name = @Name, 
                            Email = @Email, 
                            Phone = @Phone, 
                            Password = @Password, 
                            CityOrAreaName = @CityOrAreaName
                        WHERE UserName = @UserName";

                var updateUserCommand = new SqlCommand(updateUserQuery, connection);
                updateUserCommand.Parameters.AddWithValue("@Name", nameTB.Text);
                updateUserCommand.Parameters.AddWithValue("@Email", emailTB.Text);
                updateUserCommand.Parameters.AddWithValue("@Phone", phoneNumberTB.Text);
                updateUserCommand.Parameters.AddWithValue("@Password", passwordTB.Text);
                updateUserCommand.Parameters.AddWithValue("@CityOrAreaName", cityOrAreaNameTB.Text);
                updateUserCommand.Parameters.AddWithValue("@UserName", _userName);
                updateUserCommand.ExecuteNonQuery();
                updateUserCommand.Dispose();

                string updateEmployeeQuery = @"
                        UPDATE Employee 
                        SET 
                            Salary = @Salary, 
                            HireDate = @HireDate
                        WHERE UserName = @UserName";

                var updateEmployeeCommand = new SqlCommand(updateEmployeeQuery, connection);
                updateEmployeeCommand.Parameters.AddWithValue("@Salary", salaryTB.Text);
                updateEmployeeCommand.Parameters.AddWithValue("@HireDate", hireDateValue.Text);
                updateEmployeeCommand.Parameters.AddWithValue("@UserName", _userName);
                updateEmployeeCommand.ExecuteNonQuery();
                updateEmployeeCommand.Dispose();

                MessageBox.Show("Employee details updated successfully.");
                this.Close();
                _recall.LoadEmployees();
                connection.Dispose();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"An error occurred while updating the database: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RemoveEmployeeBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    var connection = DatabaseConnection.GetConnection();
                    connection.Open();

                    string deleteEmployeeQuery = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";
                    var deleteEmployeeCommand = new SqlCommand(deleteEmployeeQuery, connection);
                    deleteEmployeeCommand.Parameters.AddWithValue("@EmployeeID", _employeeIdValue);
                    deleteEmployeeCommand.ExecuteNonQuery();
                    deleteEmployeeCommand.Dispose();

                    string deleteUserQuery = "DELETE FROM Users WHERE UserName = @UserName";
                    var deleteUserCommand = new SqlCommand(deleteUserQuery, connection);
                    deleteUserCommand.Parameters.AddWithValue("@UserName", _userName);
                    deleteUserCommand.ExecuteNonQuery();
                    deleteUserCommand.Dispose();

                    MessageBox.Show("Employee data deleted successfully.");
                    this.Close();
                    _recall.LoadEmployees();
                    connection.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the employee data: {ex.Message}");
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
