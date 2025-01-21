using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using PetMate_Shop.Models;
using PetMate_Shop.Views;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetMate_Shop.ComponentCarts
{
    public partial class AcceptHelp : UserControl
    {
        string _volunteerUserName;
        string _phoneNumber;
        string _volunteerId;
        string _customerId;
        public AcceptHelp(string volunteerUserName, string volunteerId,
        string phoneNumber, string customerId)
        {
            InitializeComponent();
            _volunteerUserName = volunteerUserName;
            _volunteerId = volunteerId;
            _phoneNumber = phoneNumber;
            _customerId = customerId;
            UploadData();
        }

        private void UploadData()
        {
            volunteerUserNameLabel.Text = _volunteerUserName;
            phoneNumberLabel.Text = _phoneNumber;
        }

        private void workDoneBtn_Click(object sender, EventArgs e)
        {
            string queryHelpRequestUpdate = @"
            UPDATE HelpRequest 
            SET Status = 'work done'
            WHERE Status = 'accepted' AND CustomerID = @CustomerID AND VolunteerID = @VolunteerID";

            string queryVolunteerUpdate = @"
            UPDATE Volunteer
            SET TasksCompleted = TasksCompleted + 1, 
                RewardPoints = RewardPoints + 10, 
                WorkActiveStatus = 0
            WHERE VolunteerID = @VolunteerID";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                SqlCommand command = new SqlCommand(queryHelpRequestUpdate, connection);
                command.Parameters.AddWithValue("@CustomerID", _customerId);
                command.Parameters.AddWithValue("@VolunteerID", _volunteerId);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(queryVolunteerUpdate, connection);
                command.Parameters.AddWithValue("@VolunteerID", _volunteerId);
                command.ExecuteNonQuery();
                command.Dispose();

                connection.Dispose();

                string message = "The work has been marked as completed.";
                MakeNotification.AddNotification(_volunteerUserName, message);

                MessageBox.Show("Work completed and status updated.");
                HelpForm.instance.LoadAcceptHelp(MainForm.instance._userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            string queryHelpRequestUpdate = @"
            UPDATE HelpRequest 
            SET Status = 'cancel' 
            WHERE Status = 'accepted' AND CustomerID = @CustomerID AND VolunteerID = @VolunteerID";

            string queryVolunteerUpdate = @"
            UPDATE Volunteer
            SET WorkActiveStatus = 0
            WHERE VolunteerID = @VolunteerID";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                SqlCommand command = new SqlCommand(queryHelpRequestUpdate, connection);
                command.Parameters.AddWithValue("@CustomerID", _customerId);
                command.Parameters.AddWithValue("@VolunteerID", _volunteerId);
                command.ExecuteNonQuery();
                command.Dispose();

                command = new SqlCommand(queryVolunteerUpdate, connection);
                command.Parameters.AddWithValue("@VolunteerID", _volunteerId);
                command.ExecuteNonQuery();
                command.Dispose();

                connection.Dispose();

                string message = "The help request has been cancelled.";
                MakeNotification.AddNotification(_volunteerUserName, message);

                MessageBox.Show("Help request cancelled and status updated.");
                HelpForm.instance.LoadAcceptHelp(MainForm.instance._userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
