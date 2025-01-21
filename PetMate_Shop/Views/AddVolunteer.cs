using PetMate_Shop.Models;
using PetMate_Shop.ComponentForms;
using System;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class AddVolunteer : Form
    {
        private UsersForm _recall;

        public AddVolunteer(UsersForm recall)
        {
            InitializeComponent();
            _recall = recall;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            string volunteerId = IdCreator.GenerateId("Volunteer", "V", 2, 2);
            string name = nameTB.Text.Trim();
            string email = emailTB.Text.Trim();
            string phone = phoneNumberTB.Text.Trim();
            string houseNumber = houseOrBuildingOrFlatNumberTB.Text.Trim();
            string streetNumber = streetNameOrNumberTB.Text.Trim();
            string cityName = cityOrAreaNameTB.Text.Trim();
            string postalCode = postalCodeTB.Text.Trim();
            string password = passwordTB.Text.Trim();
            string userName = userNameTB.Text.Trim();
            string questionOneAns = questionOneTB.Text.Trim();
            string questionTwoAns = questionTwoTB.Text.Trim();
            string questionThreeAns = questionThreeTB.Text.Trim();

            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(houseNumber) || string.IsNullOrEmpty(streetNumber) || string.IsNullOrEmpty(cityName) ||
                string.IsNullOrEmpty(postalCode) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(userName) ||
                string.IsNullOrEmpty(questionOneAns) || string.IsNullOrEmpty(questionTwoAns) || string.IsNullOrEmpty(questionThreeAns))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                Volunteer volunteer = new Volunteer(
                    volunteerId,
                    userName,
                    password,
                    name,
                    email,
                    phone,
                    houseNumber,
                    streetNumber,
                    cityName,
                    postalCode,
                    questionOneAns,
                    questionTwoAns,
                    questionThreeAns
                );

                
                volunteer.CreateUserInDatabase();

                MessageBox.Show("Volunteer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                _recall.LoadVolunteers();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordTB.UseSystemPasswordChar = !passwordTB.UseSystemPasswordChar;
        }
    }
}
