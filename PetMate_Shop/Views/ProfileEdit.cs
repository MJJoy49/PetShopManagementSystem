using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class ProfileEdit : Form
    {
        private string _userName;
        private string _nameValue;
        private string _emailValue;
        private string _phoneValue;
        private string _houseBuildingFlatNumberValue;
        private string _streetNameNumberValue;
        private string _cityAreaNameValue;
        private string _postalCodeValue;
        private UserProfileForm _parentForm;

        public ProfileEdit(
            string userName,
            string nameValue,
            string emailValue,
            string phoneValue,
            string houseBuildingFlatNumberValue,
            string streetNameNumberValue,
            string cityAreaNameValue,
            string postalCodeValue,
            UserProfileForm parentForm
        )
        {
            _userName = userName;
            _nameValue = nameValue;
            _emailValue = emailValue;
            _phoneValue = phoneValue;
            _houseBuildingFlatNumberValue = houseBuildingFlatNumberValue;
            _streetNameNumberValue = streetNameNumberValue;
            _cityAreaNameValue = cityAreaNameValue;
            _postalCodeValue = postalCodeValue;
            _parentForm = parentForm;

            InitializeComponent();
            displayInfo();
        }

        private void displayInfo()
        {
            nameTB.Text = _nameValue;
            emailTB.Text = _emailValue;
            phoneNumberTB.Text = _phoneValue;
            houseOrBuildingOrFlatNumberTB.Text = _houseBuildingFlatNumberValue;
            streetNameOrNumberTB.Text = _streetNameNumberValue;
            cityOrAreaNameTB.Text = _cityAreaNameValue;
            postalCodeTB.Text = _postalCodeValue;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void forgetPasswordBtn_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm form = new ForgetPasswordForm(0);
            form.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var connection = DatabaseConnection.GetConnection();
            string query = @"
                    UPDATE Users
                    SET 
                        Name = @Name,
                        Email = @Email,
                        Phone = @Phone,
                        HouseOrBuildingOrFlatNumber = @House,
                        StreetNameOrNumber = @Street,
                        CityOrAreaName = @City,
                        PostalCode = @PostalCode,
                        UpdatedAt = @UpdatedAt
                    WHERE UserName = @UserName";

            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", _userName);
            command.Parameters.AddWithValue("@Name", nameTB.Text.Trim());
            command.Parameters.AddWithValue("@Email", emailTB.Text.Trim());
            command.Parameters.AddWithValue("@Phone", phoneNumberTB.Text.Trim());
            command.Parameters.AddWithValue("@House", houseOrBuildingOrFlatNumberTB.Text.Trim());
            command.Parameters.AddWithValue("@Street", streetNameOrNumberTB.Text.Trim());
            command.Parameters.AddWithValue("@City", cityOrAreaNameTB.Text.Trim());
            command.Parameters.AddWithValue("@PostalCode", postalCodeTB.Text.Trim());
            command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the parent form data
                    _parentForm.FetchUserData();
                    _parentForm.PrintValues();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No rows were updated. Please check the UserName.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
