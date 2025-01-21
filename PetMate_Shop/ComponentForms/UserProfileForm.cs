using PetMate_Shop.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PetMate_Shop.Views;
using PetMate_Shop.Models;
using PetMate_Shop.ComponentCarts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;

namespace PetMate_Shop.ComponentForms
{
    public partial class UserProfileForm : UserControl
    {
        public static UserProfileForm instance;
        string _userName;
        string _role;
        public string _idValue { get; set; }
        public string _nameValue { get; set; }
        public string _emailValue { get; set; }
        public string _phoneValue { get; set; }
        public string _accountCreateDate { get; set; }
        public string _houseBuildingFlatNumberValue { get; set; }
        public string _streetNameNumberValue { get; set; }
        public string _cityAreaNameValue { get; set; }
        public string _postalCodeValue { get; set; }
        public string _ruleValue { get; set; }

        public UserProfileForm(string username, string role)
        {
            InitializeComponent();

            _userName = username;
            _role = role;

            FetchUserData();
            PrintValues();

            ProfileLayoutPanelDetails(_ruleValue, _idValue);
            instance = this;
        }

        public void FetchUserData()
        {
            var connection = DatabaseConnection.GetConnection();
            string query = "SELECT UserName, Name, Email, Phone, CreatedAt, Role, HouseOrBuildingOrFlatNumber, StreetNameOrNumber, CityOrAreaName, PostalCode " +
                           "FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", _userName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    _idValue = reader["UserName"]?.ToString() ?? "No Data";
                    _nameValue = reader["Name"]?.ToString() ?? "No Data";
                    _emailValue = reader["Email"]?.ToString() ?? "No Data";
                    _phoneValue = reader["Phone"]?.ToString() ?? "No Data";
                    _accountCreateDate = reader["CreatedAt"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedAt"]).ToString("dd-MM-yyyy") : "No Data";
                    _houseBuildingFlatNumberValue = reader["HouseOrBuildingOrFlatNumber"]?.ToString() ?? "No Data";
                    _streetNameNumberValue = reader["StreetNameOrNumber"]?.ToString() ?? "No Data";
                    _cityAreaNameValue = reader["CityOrAreaName"]?.ToString() ?? "No Data";
                    _postalCodeValue = reader["PostalCode"]?.ToString() ?? "No Data";
                    _ruleValue = reader["Role"]?.ToString() ?? "No Data";

                    DetermineRoleBasedID();
                }
                else
                {
                    MessageBox.Show("User data not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DetermineRoleBasedID()
        {
            string idColumn = string.Empty;

            switch (_ruleValue)
            {
                case "Customer":
                    idColumn = "CustomerID";
                    break;
                case "Admin":
                    idColumn = "AdminID";
                    break;
                case "Employee":
                    idColumn = "EmployeeID";
                    break;
                case "Volunteer":
                    idColumn = "VolunteerID";
                    break;
                default:
                    MessageBox.Show("Invalid role specified!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            string query = $"SELECT {idColumn} FROM {_ruleValue} WHERE UserName = @UserName";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", _userName);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    _idValue = reader[idColumn]?.ToString() ?? "No Data";
                }
                else
                {
                    MessageBox.Show($"No data found for UserName: {_userName}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrintValues()
        {
            idValue.Text = _idValue;
            nameValue.Text = _nameValue;
            emailValue.Text = _emailValue;
            phoneValue.Text = _phoneValue;
            accountCreateDate.Text = _accountCreateDate;
            houseBuildingFlatNumberValue.Text = _houseBuildingFlatNumberValue;
            streetNameNumberValue.Text = _streetNameNumberValue;
            cityAreaNameValue.Text = _cityAreaNameValue;
            postalCodeValue.Text = _postalCodeValue;
            ruleValue.Text = "{" + _ruleValue + "}";
        }

        private void profileInfoEditBtn_Click(object sender, EventArgs e)
        {
            var profileEdit = new ProfileEdit(
              _userName,
             _nameValue,
             _emailValue,
             _phoneValue,
             _houseBuildingFlatNumberValue,
             _streetNameNumberValue,
             _cityAreaNameValue,
             _postalCodeValue,
             this
         );

            profileEdit.Show();
        }

        public void ProfileLayoutPanelDetails(string rule, string userId)
        {
            if (rule == "Customer")
            {
                forCustomer(userId);
            }

            else if (rule == "Volunteer")
            {
                forVolunteer(userId);
            }

            else
            {
                return;
            }
        }

        public void forCustomer(string userId)
        {
            ProfileLayoutPanel.Visible = true;
            ProfileLayoutPanel.Controls.Clear();

            string query = @"
                    SELECT PetID, AdoptedBy, PurchaseDate
                    FROM BuyPet
                    WHERE CustomerID = @CustomerID";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", userId);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string petID = reader["PetID"].ToString();
                string adoptedBy = reader["AdoptedBy"].ToString();
                string purchaseDate = Convert.ToDateTime(reader["PurchaseDate"]).ToString("dd-MM-yyyy"); ;

                BuyPetID buyPetID = new BuyPetID(petID, purchaseDate.ToString(), adoptedBy, _idValue);

                ProfileLayoutPanel.Controls.Add(buyPetID);
            }
            reader.Close();
        }

        private void forVolunteer(string userId)
        {

        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            if (_role == "Customer")
            {
                ProfileLayoutPanel.Visible = true;
                historyTitle.Visible = true;
                detailsPanel.Location = new Point(48, 58);
            }

            else if (_role == "Employee")
            {
                detailsPanel.Location = new Point(45, 415);
            }

            else if (_role == "Volunteer")
            {
                getForVolunTeer(_idValue);
                forVolunteerPanel.Visible = true;
                forVolunteerPanel.Location = new Point(184, 619);
            }
            else
            {
                detailsPanel.Location = new Point(45, 415);
            }
        }

        void getForVolunTeer(string idValue)
        {
            string query = @"
                SELECT TasksCompleted, RewardPoints 
                FROM Volunteer 
                WHERE VolunteerID = @VolunteerID";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VolunteerID", idValue);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                tasksCompletedValue.Text = reader["TasksCompleted"]?.ToString() ?? "0";
                rewardPointsValue.Text = reader["RewardPoints"]?.ToString() ?? "0";
            }
            else
            {
                tasksCompletedValue.Text = "0";
                rewardPointsValue.Text = "0";
            }

            reader.Close();
        }
    }
}
