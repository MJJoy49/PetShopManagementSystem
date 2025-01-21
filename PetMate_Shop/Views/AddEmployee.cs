using System;
using System.Windows.Forms;
using PetMate_Shop.ComponentForms;
using PetMate_Shop.Models;

namespace PetMate_Shop.Views
{
    public partial class AddEmployee : Form
    {
        string _name;
        string _email;
        string _password;
        string _phone;
        string _userName;
        string _cityOrAreaName;
        string _questionAnsOne;
        string _questionAnsTwo;
        string _questionAnsThree;
        float _salary;
        string _employeeID;
        DateTime _hireDate;
        UsersForm recall;

        public AddEmployee(UsersForm usersForm)
        {
            recall = usersForm;
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _name = nameTB.Text.Trim();
            _email = emailTB.Text.Trim();
            _phone = phoneNumberTB.Text.Trim();
            _cityOrAreaName = cityOrAreaNameTB.Text.Trim();
            _password = passwordTB.Text.Trim();
            _userName = userNameTB.Text.Trim();
            _questionAnsOne = questionOneTB.Text.Trim();
            _questionAnsTwo = questionTwoTB.Text.Trim();
            _questionAnsThree = questionThreeTB.Text.Trim();

            bool isSalaryValid = float.TryParse(salaryTB.Text.Trim(), out _salary);

            if (string.IsNullOrEmpty(_name) || string.IsNullOrEmpty(_email) || string.IsNullOrEmpty(_phone) ||
                string.IsNullOrEmpty(_cityOrAreaName) || string.IsNullOrEmpty(_password) || string.IsNullOrEmpty(_userName) ||
                string.IsNullOrEmpty(_questionAnsOne) || string.IsNullOrEmpty(_questionAnsTwo) || string.IsNullOrEmpty(_questionAnsThree) ||
                !isSalaryValid)
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _employeeID = IdCreator.GenerateId("Employee", "E", 2, 2);
            _hireDate = DateTime.Now;

            Employee newEmployee = new Employee(
                _employeeID, _userName, _password, _name, _email, _phone,
                "Employee", _questionAnsOne, _questionAnsTwo, _questionAnsThree,
                "no Data", "no Data", _cityOrAreaName, "no Data", _salary, _hireDate
            );

            try
            {
                newEmployee.CreateUserInDatabase();

                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                recall.LoadEmployees();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
