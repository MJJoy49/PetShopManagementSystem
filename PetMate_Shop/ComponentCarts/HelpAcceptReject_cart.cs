using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using PetMate_Shop.Models;
using PetMate_Shop.Views;

namespace PetMate_Shop.ComponentCarts
{
    public partial class HelpAcceptReject_cart : UserControl
    {
        private string _customerUserName;
        private string _petId;
        private string _customerPhone;
        private string _customerHelpDescription;
        private string _customerCityOrAreaName;
        private string _customerId;
        private string _volunteerId;

        public HelpAcceptReject_cart(string customerUserName,
                                     string petId,
                                     string customerPhone,
                                     string customerHelpDescription,
                                     string customerCityOrAreaName,
                                     string customerId,
                                     string volunteerId)
        {
            InitializeComponent();

            _customerUserName = customerUserName;
            _petId = petId;
            _customerPhone = customerPhone;
            _customerHelpDescription = customerHelpDescription;
            _customerCityOrAreaName = customerCityOrAreaName;
            _customerId = customerId;
            _volunteerId = volunteerId;

            UploadData();
        }

        private void UploadData()
        {
            userNameLabel.Text = _customerUserName;
            petIdLabel.Text = _petId;
            customerIdLabel.Text = _customerId;
            cityAreaNameLabel.Text = _customerCityOrAreaName;
            descriptionBox.Text = _customerHelpDescription;
            phoneNumberLabel.Text = _customerPhone;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string updateRequestQuery = @"UPDATE HelpRequest SET Status = 'accepted' WHERE VolunteerID = @VolunteerID AND CustomerID = @CustomerID";
                var command = new SqlCommand(updateRequestQuery, connection);
                command.Parameters.AddWithValue("@VolunteerID", _volunteerId);
                command.Parameters.AddWithValue("@CustomerID", _customerId);
                command.ExecuteNonQuery();
                command.Dispose();

                string updateVolunteerQuery = @"UPDATE Volunteer SET WorkActiveStatus = 1 WHERE VolunteerID = @VolunteerID";
                command = new SqlCommand(updateVolunteerQuery, connection);
                command.Parameters.AddWithValue("@VolunteerID", _volunteerId);
                command.ExecuteNonQuery();
                command.Dispose();

                MakeNotification.AddNotification(_customerUserName, "Your help request has been accepted.");

                MessageBox.Show("Request accepted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Dispose();


                //recall;
                HelpForm.instance.LoadVolunteerReq(MainForm.instance._userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string updateRequestQuery = @"UPDATE HelpRequest SET Status = 'rejected' WHERE VolunteerID = @VolunteerID AND CustomerID = @CustomerID";
                var command = new SqlCommand(updateRequestQuery, connection);
                command.Parameters.AddWithValue("@VolunteerID", _volunteerId);
                command.Parameters.AddWithValue("@CustomerID", _customerId);
                command.ExecuteNonQuery();
                command.Dispose();

                MakeNotification.AddNotification(_customerUserName, "Your help request has been rejected.");

                MessageBox.Show("Request rejected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Dispose();

                //recall;
                HelpForm.instance.LoadVolunteerReq(MainForm.instance._userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
