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
    public partial class ForgetPasswordForm : Form
    {
        string _userNameOrEmail;
        string _questionOneAns;
        string _questionTwoAns;
        string _questionThreeAns;

        string _newPassword;
        string _newRePassword;

        int _onlyOff = 1;

        string _userName;
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        public ForgetPasswordForm(int onlyOff)
        {
            InitializeComponent();
            _onlyOff = onlyOff;
        }

        private void recoverPassBtn_Click(object sender, EventArgs e)
        {
            _userNameOrEmail = userNameOrGmailTB.Text.Trim();
            _questionOneAns = questionOneTB.Text.Trim();
            _questionTwoAns = questionTwoTB.Text.Trim();
            _questionThreeAns = questionThreeTB.Text.Trim();

            string query = @"SELECT UserName FROM Users 
                     WHERE (UserName = @UserNameOrEmail OR Email = @UserNameOrEmail)
                     AND QuestionOneAns = @QuestionOneAns
                     AND QuestionTwoAns = @QuestionTwoAns
                     AND QuestionThreeAns = @QuestionThreeAns";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserNameOrEmail", _userNameOrEmail);
            command.Parameters.AddWithValue("@QuestionOneAns", _questionOneAns);
            command.Parameters.AddWithValue("@QuestionTwoAns", _questionTwoAns);
            command.Parameters.AddWithValue("@QuestionThreeAns", _questionThreeAns);

            var result = command.ExecuteScalar();

            if (result != null)
            {
                _userName = result.ToString();
                showUsernameLabel.Text = _userName;
                infoForRecoverPasswordPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid username/email or incorrect answers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            command.Dispose();
            connection.Dispose();
        }

        private void setPasswordBtn_Click(object sender, EventArgs e)
        {
            _newPassword = newPasswordTB.Text.Trim();
            _newRePassword = newRePasswordTB.Text.Trim();

            if (_newPassword == _newRePassword)
            {
                string query = @"UPDATE Users
                         SET Password = @NewPassword
                         WHERE UserName = @UserName";

                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewPassword", _newPassword);
                command.Parameters.AddWithValue("@UserName", _userName);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        if (_onlyOff == 1)
                        {
                            var loginForm = new LoginForm();
                            loginForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No user found with the specified username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        infoForRecoverPasswordPanel.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                command.Dispose();
                connection.Dispose();
            }
            else
            {
                MessageBox.Show("The passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
