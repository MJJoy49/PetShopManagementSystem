using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PetMate_Shop.Database;
using PetMate_Shop.ComponentCarts;
using PetMate_Shop.Views;

namespace PetMate_Shop.ComponentForms
{
    public partial class NotificationForm : UserControl
    {
        public static NotificationForm instance;
        string _userName;
        string _role;

        public NotificationForm(string userName, string role)
        {
            _userName = userName;
            _role = role;
            InitializeComponent();
            LoadNotificationCard(_userName);
            instance = this;
        }

        public void markNotificationsAsSeen(string userName)
        {
            string checkRoleQuery = @"SELECT COUNT(*) 
                      FROM Users 
                      WHERE UserName = @UserName AND Role = 'Customer';";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();

            var roleCommand = new SqlCommand(checkRoleQuery, connection);
            roleCommand.Parameters.AddWithValue("@UserName", userName);

            int isCustomer = (int)roleCommand.ExecuteScalar();

            if (isCustomer == 0)
            {
                roleCommand.Dispose();
                connection.Dispose();
                return;
            }

            string updateQuery = @"UPDATE Notification
                                   SET Status = 'seen'
                                   WHERE UserName = @UserName AND Status = 'unseen';";

            var updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@UserName", userName);

            int rowsAffected = updateCommand.ExecuteNonQuery();

            MainForm.instance.unseenNotificationCount(userName);
            LoadNotificationCard(userName);

            updateCommand.Dispose();
            roleCommand.Dispose();
            connection.Dispose();
        }

        public void LoadNotificationCard(string userName)
        {
            string query = @"
                                SELECT 
                                    SentDate, 
                                    Message, 
                                    Status 
                                FROM 
                                    Notification 
                                WHERE 
                                    UserName = @UserName
                                ORDER BY 
                                    SentDate DESC";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);

                var reader = command.ExecuteReader();

                NoticationflowLayoutPanel.Controls.Clear();

                while (reader.Read())
                {
                    string sentDate = Convert.ToDateTime(reader["SentDate"]).ToString("MM/dd/yyyy");
                    string message = reader["Message"].ToString();
                    string status = reader["Status"].ToString();

                    NotificationCard notificationCard = new NotificationCard(
                        sentDate,
                        message,
                        status
                    );

                    NoticationflowLayoutPanel.Controls.Add(notificationCard);
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

        private void NotificationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
