using PetMate_Shop.ComponentCarts;
using PetMate_Shop.Database;
using PetMate_Shop.Views;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PetMate_Shop.ComponentForms
{
    public partial class UsersForm : UserControl
    {
        string _userName;
        string _role;
        public UsersForm(string username, string role)
        {
            _userName = username;
            _role = role;
            InitializeComponent();
        }

        public void LoadEmployees()
        {
            usersShowPanel.Controls.Clear();

            string query = "SELECT EmployeeID, UserName, Salary, HireDate FROM Employee";
            var connection = DatabaseConnection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string employeeId = reader["EmployeeID"].ToString();
                string userName = reader["UserName"].ToString();
                string salary = reader["Salary"].ToString();
                string hireDate = Convert.ToDateTime(reader["HireDate"]).ToString("yyyy-MM-dd");

                var employeeCard = new EmployeeCard(employeeId, userName, salary, hireDate, this)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

                usersShowPanel.Controls.Add(employeeCard);
            }
            reader.Close();
            connection.Close();
        }

        public void LoadVolunteers()
        {
            usersShowPanel.Controls.Clear();

            string query = "SELECT VolunteerID, UserName, TasksCompleted, RewardPoints FROM Volunteer";
            var connection = DatabaseConnection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string volunteerId = reader["VolunteerID"].ToString();
                string userName = reader["UserName"].ToString();
                string tasksCompleted = reader["TasksCompleted"].ToString();
                string rewardPoints = reader["RewardPoints"].ToString();

                var volunteerCard = new VolunteerCart(volunteerId, userName, tasksCompleted, rewardPoints, this)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

                usersShowPanel.Controls.Add(volunteerCard);
            }
            reader.Close();
            connection.Close();
        }

        public void LoadCustomers()
        {
            usersShowPanel.Controls.Clear();

            string query = "SELECT CustomerID, UserName FROM Customer";
            var connection = DatabaseConnection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string customerId = reader["CustomerID"].ToString();
                string userName = reader["UserName"].ToString();

                var customerCard = new CustomerCart(customerId, userName, this)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

                usersShowPanel.Controls.Add(customerCard);
            }
            reader.Close();
            connection.Close();
        }

        private void addEmployeesBtn_Click(object sender, EventArgs e)
        {
            AddEmployee employee = new AddEmployee(this);
            employee.Show();
        }

        private void addVolunteerBtn_Click(object sender, EventArgs e)
        {
            AddVolunteer addVolunteer = new AddVolunteer(this);
            addVolunteer.Show();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(this);
            addCustomer.Show();
        }

        private void employeesRA_CheckedChanged(object sender, EventArgs e)
        {
            if (employeesRA.Checked)
            {
                LoadEmployees();
            }
        }

        private void volunteerRA_CheckedChanged(object sender, EventArgs e)
        {
            if (volunteerRA.Checked)
            {
                LoadVolunteers();
            }
        }

        private void customerRA_CheckedChanged(object sender, EventArgs e)
        {
            if (customerRA.Checked)
            {
                LoadCustomers();
            }
        }

        string search;
        private void searchBtn_Click(object sender, EventArgs e)
        {
            search = searchTB.Text;

            if (customerRA.Checked)
            {
                string query = $"SELECT CustomerID, UserName FROM Customer WHERE UserName LIKE '%{search}%' OR CustomerID LIKE '%{search}%'";
                var connection = DatabaseConnection.GetConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                usersShowPanel.Controls.Clear();
                while (reader.Read())
                {
                    string customerId = reader["CustomerID"].ToString();
                    string userName = reader["UserName"].ToString();

                    var customerCard = new CustomerCart(customerId, userName, this)
                    {
                        Dock = DockStyle.Top,
                        Margin = new Padding(10)
                    };

                    usersShowPanel.Controls.Add(customerCard);
                }
                reader.Close();
                connection.Close();
                searchTB.Text = "";
            }
            else if (employeesRA.Checked)
            {
                string query = $"SELECT EmployeeID, UserName, Salary, HireDate FROM Employee WHERE UserName LIKE '%{search}%' OR EmployeeID LIKE '%{search}%'";
                var connection = DatabaseConnection.GetConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                usersShowPanel.Controls.Clear();
                while (reader.Read())
                {
                    string employeeId = reader["EmployeeID"].ToString();
                    string userName = reader["UserName"].ToString();
                    string salary = reader["Salary"].ToString();
                    string hireDate = Convert.ToDateTime(reader["HireDate"]).ToString("yyyy-MM-dd");

                    var employeeCard = new EmployeeCard(employeeId, userName, salary, hireDate, this)
                    {
                        Dock = DockStyle.Top,
                        Margin = new Padding(10)
                    };

                    usersShowPanel.Controls.Add(employeeCard);
                }
                reader.Close();
                connection.Close();
                searchTB.Text = "";
            }
            else if (volunteerRA.Checked)
            {
                string query = $"SELECT VolunteerID, UserName, TasksCompleted, RewardPoints FROM Volunteer WHERE UserName LIKE '%{search}%' OR VolunteerID LIKE '%{search}%'";
                var connection = DatabaseConnection.GetConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                usersShowPanel.Controls.Clear();
                while (reader.Read())
                {
                    string volunteerId = reader["VolunteerID"].ToString();
                    string userName = reader["UserName"].ToString();
                    string tasksCompleted = reader["TasksCompleted"].ToString();
                    string rewardPoints = reader["RewardPoints"].ToString();

                    var volunteerCard = new VolunteerCart(volunteerId, userName, tasksCompleted, rewardPoints, this)
                    {
                        Dock = DockStyle.Top,
                        Margin = new Padding(10)
                    };

                    usersShowPanel.Controls.Add(volunteerCard);
                }
                reader.Close();
                connection.Close();
                searchTB.Text = "";
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            if (_role == "Employee")
            {
                volunteerRA.Checked = true;
                LoadVolunteers();
                volunteerRA.Location = new Point(94, 161);
                customerRA.Location = new Point(263, 161);
            }
            else
            {
                LoadEmployees();
                employeesRA.Checked = true;
                addEmployeesBtn.Visible = true;
                Addpic.Visible = true;
                employeesRA.Visible = true;
                volunteerRA.Visible = true;
                customerRA.Visible = true;
            }
        }
    }
}
