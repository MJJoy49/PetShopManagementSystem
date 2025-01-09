using PetMate_Shop.Database;
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

namespace PetMate_Shop.Views
{
    public partial class LoginForm : Form
    {
        string _userName;
        string _password;






        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            userNameTB.Text = "";
            passwordTB.Text = "";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string _userName = userNameTB.Text.Trim();
            string _password = passwordTB.Text.Trim();

            string query = "SELECT COUNT(*) FROM Users WHERE UserName COLLATE SQL_Latin1_General_CP1_CS_AS = @Username AND Password COLLATE SQL_Latin1_General_CP1_CS_AS = @Password;";

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.Clear();
                        sqlCommand.Parameters.AddWithValue("@Username", _userName);
                        sqlCommand.Parameters.AddWithValue("@Password", _password);

                       
                        int userCount = (int)sqlCommand.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordTB.UseSystemPasswordChar = !passwordTB.UseSystemPasswordChar;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
