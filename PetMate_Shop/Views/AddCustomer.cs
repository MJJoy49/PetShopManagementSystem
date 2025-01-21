using PetMate_Shop.ComponentForms;
using PetMate_Shop.Models;
using System;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class AddCustomer : Form
    {
        private UsersForm _recall;

        public AddCustomer(UsersForm recall)
        {
            InitializeComponent();
            _recall = recall;
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
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

            Customer customer = new Customer(
                userName,
                password,
                name,
                email,
                phone,
                questionOneAns,
                questionTwoAns,
                questionThreeAns,
                houseNumber,
                streetNumber,
                cityName,
                postalCode
            );

            customer.CreateUserInDatabase();

            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _recall.LoadCustomers();

            this.Close();
        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordTB.UseSystemPasswordChar = !passwordTB.UseSystemPasswordChar;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
