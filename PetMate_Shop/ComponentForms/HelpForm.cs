using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using PetMate_Shop.ComponentCarts;
using PetMate_Shop.Database;

namespace PetMate_Shop.ComponentForms
{
    public partial class HelpForm : UserControl
    {
        private readonly string _userName;
        private readonly string _role;

        public HelpForm(string username, string role)
        {
            _userName = username;
            _role = role;
            InitializeComponent();
        }

        public void LoadVolunteer()
        {
            string query = @"SELECT 
                                u.Name, 
                                u.CityOrAreaName, 
                                v.VolunteerID, 
                                v.TasksCompleted 
                            FROM 
                                Volunteer v
                            INNER JOIN 
                                Users u ON v.UserName = u.UserName
                            WHERE 
                                v.WorkActiveStatus = 0";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();

                VolunteerflowLayoutPanel.Controls.Clear();

                while (reader.Read())
                {
                    string nameValue = reader["Name"].ToString();
                    string cityOrArea = reader["CityOrAreaName"].ToString();
                    string volunteerId = reader["VolunteerID"].ToString();
                    string tasksCompleted = reader["TasksCompleted"].ToString();

                    VolunteerHelps volunteerHelps = new VolunteerHelps(
                        cityOrArea,
                        tasksCompleted,
                        nameValue,
                        volunteerId
                    );

                    VolunteerflowLayoutPanel.Controls.Add(volunteerHelps);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void LoadVolunteerReq(string userName)
        {
            VolunteerflowLayoutPanel.Controls.Clear();

            string volunteerId = string.Empty;

            string volunteerQuery = "SELECT VolunteerID FROM Volunteer WHERE UserName = @UserName";
            var connection = DatabaseConnection.GetConnection();

            var command = new SqlCommand(volunteerQuery, connection);
            command.Parameters.AddWithValue("@UserName", userName);
            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                volunteerId = reader["VolunteerID"].ToString();
            }
            reader.Close();
            connection.Close();

            if (string.IsNullOrEmpty(volunteerId))
            {
                MessageBox.Show("No volunteer found for this user.");
                return;
            }

            string helpRequestQuery = @"SELECT HR.HelpRequestID, 
                                               C.UserName AS CustomerUserName, 
                                               HR.PetID, 
                                               U.Phone, 
                                               HR.HelpDescription, 
                                               U.CityOrAreaName, 
                                               C.CustomerID
                                        FROM HelpRequest HR
                                        JOIN Customer C ON C.CustomerID = HR.CustomerID
                                        JOIN Users U ON C.UserName = U.UserName
                                        WHERE HR.VolunteerID = @VolunteerID AND HR.Status = 'not accepted';";

            connection = DatabaseConnection.GetConnection();
            command = new SqlCommand(helpRequestQuery, connection);
            command.Parameters.AddWithValue("@VolunteerID", volunteerId);
            connection.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string customerUserName = reader["CustomerUserName"].ToString();
                string petId = reader["PetID"].ToString();
                string customerPhone = reader["Phone"].ToString();
                string customerHelpDescription = reader["HelpDescription"].ToString();
                string customerCityOrAreaName = reader["CityOrAreaName"].ToString();
                string customerId = reader["CustomerID"].ToString();

                HelpAcceptReject_cart helpAcceptRejectCart = new HelpAcceptReject_cart(
                    customerUserName,
                    petId,
                    customerPhone,
                    customerHelpDescription,
                    customerCityOrAreaName,
                    customerId,
                    volunteerId
                );

                VolunteerflowLayoutPanel.Controls.Add(helpAcceptRejectCart);
            }

            reader.Close();
            connection.Close();
        }

        public void LoadAcceptHelp(string userName)
        {
            VolunteerflowLayoutPanel.Controls.Clear();

            string customerId = null;
            string volunteerUserName = null;
            string phoneNumber = null;
            string volunteerId = null;

            string queryCustomer = @"
                                        SELECT CustomerID 
                                        FROM Customer
                                        WHERE UserName = @UserName";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                var command = new SqlCommand(queryCustomer, connection);
                command.Parameters.AddWithValue("@UserName", userName);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    customerId = reader["CustomerID"].ToString();
                }
                reader.Close();

                if (customerId == null)
                {
                    MessageBox.Show("Customer not found.");
                    connection.Close();
                    return;
                }

                string queryHelpRequest = @"
                SELECT HelpRequestID, VolunteerID 
                FROM HelpRequest 
                WHERE CustomerID = @CustomerID AND Status = 'accepted'";

                command = new SqlCommand(queryHelpRequest, connection);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    volunteerId = reader["VolunteerID"].ToString();
                }
                reader.Close();

                if (volunteerId != null)
                {
                    string queryVolunteer = @"
                    SELECT UserName 
                    FROM Volunteer 
                    WHERE VolunteerID = @VolunteerID";

                    command = new SqlCommand(queryVolunteer, connection);
                    command.Parameters.AddWithValue("@VolunteerID", volunteerId);
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        volunteerUserName = reader["UserName"].ToString();
                    }
                    reader.Close();

                    if (volunteerUserName != null)
                    {
                        string queryUserPhone = @"
                        SELECT Phone 
                        FROM Users 
                        WHERE UserName = @UserName";

                        command = new SqlCommand(queryUserPhone, connection);
                        command.Parameters.AddWithValue("@UserName", volunteerUserName);
                        reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            phoneNumber = reader["Phone"].ToString();
                        }
                        reader.Close();
                    }

                    AcceptHelp acceptHelp = new AcceptHelp(volunteerUserName, volunteerId, phoneNumber, customerId);
                    VolunteerflowLayoutPanel.Controls.Add(acceptHelp);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            if (_role == "Customer")
            {
                LoadVolunteer();
                acceptHelp.Location = new Point(291, 63);
                acceptHelp.Visible = true;
            }
            else if (_role == "Volunteer")
            {
                LoadVolunteerReq(_userName);
                allVolunteerBtn.Visible = false;
                myRequest.Location = new Point(66, 63);
                myRequest.Visible = true;
            }
        }

        private void allVolunteerBtn_Click(object sender, EventArgs e)
        {
            LoadVolunteer();
        }

        private void myRequest_Click(object sender, EventArgs e)
        {
            LoadVolunteerReq(_userName);
        }

        private void acceptHelp_Click(object sender, EventArgs e)
        {
            LoadAcceptHelp(_userName);
        }
    }
}
