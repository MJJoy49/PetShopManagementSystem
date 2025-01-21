using PetMate_Shop.Models;
using System;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class RegisterForm : Form
    {
        string _name;
        string _email;
        string _password;
        string _rePassword;
        string _phone;
        string _userName;
        string _houseOrBuildingOrFlatNumber;
        string _streetNameOrNumber;
        string _cityOrAreaName;
        string _postalCode;
        string _questionAnsOne;
        string _questionAnsTwo;
        string _questionAnsThree;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            _name = nameTB.Text.Trim();
            _email = emailTB.Text.Trim();
            _phone = phoneNumberTB.Text.Trim();
            _houseOrBuildingOrFlatNumber = houseOrBuildingOrFlatNumberTB.Text.Trim();
            _streetNameOrNumber = streetNameOrNumberTB.Text.Trim();
            _postalCode = postalCodeTB.Text.Trim();
            _cityOrAreaName = cityOrAreaNameTB.Text.Trim();

            if (string.IsNullOrWhiteSpace(_name) || string.IsNullOrWhiteSpace(_email) || string.IsNullOrWhiteSpace(_houseOrBuildingOrFlatNumber) || string.IsNullOrWhiteSpace(_streetNameOrNumber) ||
               string.IsNullOrWhiteSpace(_postalCode))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(_email))
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            addressPanel.Visible = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            addressPanel.Visible = true;
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            _password = passwordTB.Text.Trim();
            _rePassword = rePasswordTB.Text.Trim();
            _userName = userNameTB.Text.Trim();
            _questionAnsOne = questionOneTB.Text.Trim();
            _questionAnsTwo = questionTwoTB.Text.Trim();
            _questionAnsThree = questionThreeTB.Text.Trim();

            if (string.IsNullOrWhiteSpace(_userName) || string.IsNullOrWhiteSpace(_password) || string.IsNullOrWhiteSpace(_rePassword) || string.IsNullOrWhiteSpace(_name) ||
                string.IsNullOrWhiteSpace(_email) || string.IsNullOrWhiteSpace(_questionAnsOne) || string.IsNullOrWhiteSpace(_questionAnsTwo) || string.IsNullOrWhiteSpace(_questionAnsThree))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_password != _rePassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer customer = new Customer(
                _userName,
                _password,
                _name,
                _email,
                _phone,
                _questionAnsOne,
                _questionAnsTwo,
                _questionAnsThree,
                _houseOrBuildingOrFlatNumber,
                _streetNameOrNumber,
                _cityOrAreaName,
                _postalCode
            );

            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
