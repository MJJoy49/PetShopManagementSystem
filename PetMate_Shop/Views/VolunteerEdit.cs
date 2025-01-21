using PetMate_Shop.ComponentForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PetMate_Shop.Database;

namespace PetMate_Shop.Views
{
    public partial class VolunteerEdit : Form
    {
        private string _userName;
        private string _tasksCompletedValue;
        private string _rewardPointsValue;
        private UsersForm _recall;

        public VolunteerEdit(string userName, UsersForm recall, string tasksCompletedValue, string rewardPointsValue)
        {
            InitializeComponent();
            _userName = userName;
            _recall = recall;
            _tasksCompletedValue = tasksCompletedValue;
            _rewardPointsValue = rewardPointsValue;

            showData();
        }

        private void showData()
        {
            var connection = DatabaseConnection.GetConnection();
            string query = $"SELECT * FROM Users WHERE UserName = '{_userName}'";
            var command = new SqlCommand(query, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                nameTB.Text = reader["Name"].ToString();
                emailTB.Text = reader["Email"].ToString();
                phoneNumberTB.Text = reader["Phone"].ToString();
                cityOrAreaNameTB.Text = reader["CityOrAreaName"].ToString();
                passwordTB.Text = reader["Password"].ToString();
                userNameTB.Text = reader["UserName"].ToString();
            }
            reader.Close();
            command.Dispose();

            query = $"SELECT * FROM Volunteer WHERE UserName = '{_userName}'";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                tasksCompletedValue.Text = reader["TasksCompleted"].ToString();
                rewardPointsValue.Text = reader["RewardPoints"].ToString();
            }
            reader.Close();
            command.Dispose();
            connection.Dispose();
        }

        private void VolunteerEdit_Load(object sender, EventArgs e)
        {
           
        }

        private void EditVolunteerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTB.Text) ||
                string.IsNullOrEmpty(emailTB.Text) ||
                string.IsNullOrEmpty(phoneNumberTB.Text) ||
                string.IsNullOrEmpty(passwordTB.Text) ||
                string.IsNullOrEmpty(cityOrAreaNameTB.Text) ||
                string.IsNullOrEmpty(tasksCompletedValue.Text) ||
                string.IsNullOrEmpty(rewardPointsValue.Text))
            {
                MessageBox.Show("Please fill in all the fields before updating the volunteer details.");
                return;
            }

            var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string updateUserQuery = $@"
                    UPDATE Users 
                    SET 
                        Name = '{nameTB.Text}', 
                        Email = '{emailTB.Text}', 
                        Phone = '{phoneNumberTB.Text}', 
                        Password = '{passwordTB.Text}', 
                        CityOrAreaName = '{cityOrAreaNameTB.Text}'
                    WHERE UserName = '{_userName}'";

            var updateUserCommand = new SqlCommand(updateUserQuery, connection);
            updateUserCommand.ExecuteNonQuery();
            updateUserCommand.Dispose();

            string updateVolunteerQuery = $@"
                    UPDATE Volunteer 
                    SET 
                        TasksCompleted = {tasksCompletedValue.Text}, 
                        RewardPoints = {rewardPointsValue.Text}
                    WHERE UserName = '{_userName}'";

            var updateVolunteerCommand = new SqlCommand(updateVolunteerQuery, connection);
            updateVolunteerCommand.ExecuteNonQuery();
            updateVolunteerCommand.Dispose();

            connection.Dispose();

            MessageBox.Show("Volunteer details updated successfully.");
            this.Close();
            _recall.LoadVolunteers();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RemoveVolenteerBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this volunteer and their related data?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string deleteVolunteerQuery = $"DELETE FROM Volunteer WHERE UserName = '{_userName}'";
                var deleteVolunteerCommand = new SqlCommand(deleteVolunteerQuery, connection);
                deleteVolunteerCommand.ExecuteNonQuery();
                deleteVolunteerCommand.Dispose();

                string deleteUserQuery = $"DELETE FROM Users WHERE UserName = '{_userName}'";
                var deleteUserCommand = new SqlCommand(deleteUserQuery, connection);
                deleteUserCommand.ExecuteNonQuery();
                deleteUserCommand.Dispose();

                connection.Dispose();

                MessageBox.Show("Volunteer and related user data deleted successfully.");
                this.Close();
                _recall.LoadVolunteers();
            }
            else
            {
                MessageBox.Show("Operation canceled.");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
