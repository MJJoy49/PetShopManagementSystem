using PetMate_Shop.ComponentForms;
using System;
using System.Windows.Forms;
using PetMate_Shop.Views;

namespace PetMate_Shop.ComponentCarts
{
    public partial class EmployeeCard : UserControl
    {
        private string _employeeIdValue;
        private string _userNameValue;
        private string _salaryValue;
        private string _hireDateValue;
        private UsersForm _recall;

        public EmployeeCard(
            string employeeIdValue,
            string userNameValue,
            string salaryValue,
            string hireDateValue,
            UsersForm recall
        )
        {
            InitializeComponent();

            _employeeIdValue = employeeIdValue;
            _userNameValue = userNameValue;
            _salaryValue = salaryValue;
            _hireDateValue = hireDateValue;
            _recall = recall;

            showData();
        }

        void showData()
        {
            employeeIdValue.Text = _employeeIdValue;
            userNameValue.Text = _userNameValue;
            salaryValue.Text = _salaryValue;
            hireDateValue.Text = _hireDateValue;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditEmployee editEmployee = new EditEmployee(
                _recall,
                _hireDateValue,
                _userNameValue,
                _salaryValue,
                _employeeIdValue
            );

            editEmployee.Show();
        }
    }
}
