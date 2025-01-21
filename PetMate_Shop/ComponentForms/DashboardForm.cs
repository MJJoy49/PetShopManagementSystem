using PetMate_Shop.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetMate_Shop.ComponentForms
{
    public partial class DashboardForm : UserControl
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        public void updata()
        {
            string totalIncomeQuery = @"
                SELECT SUM(Amount)
                FROM Payment
                WHERE PaymentStatus = 'Completed';";

            string totalSellQuery = @"
                SELECT SUM(Quantity)
                FROM AddCart
                WHERE CartStatus = 'Closed';";

            string totalCustomerQuery = @"
                SELECT COUNT(*) 
                FROM Customer;";

            string totalVolunteerQuery = @"
                SELECT COUNT(*) 
                FROM Volunteer;";

            string totalEmployeeQuery = @"
                SELECT COUNT(*) 
                FROM Employee;";

            string totalAccessoriesQuery = @"
                SELECT SUM(Stock)
                FROM Accessories;";

            string totalPetsQuery = @"
                SELECT COUNT(*) 
                FROM Pet;";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();

            var incomeCommand = new SqlCommand(totalIncomeQuery, connection);
            var incomeResult = incomeCommand.ExecuteScalar();
            if (incomeResult == DBNull.Value)
            {
                totalIncome.Text = "0" + " TK";
            }
            else
            {
                totalIncome.Text = incomeResult.ToString() + " TK";
            }
            incomeCommand.Dispose();

            var sellCommand = new SqlCommand(totalSellQuery, connection);
            var sellResult = sellCommand.ExecuteScalar();
            if (sellResult == DBNull.Value)
            {
                totalSell.Text = "0";
            }
            else
            {
                totalSell.Text = sellResult.ToString();
            }
            sellCommand.Dispose();

            var customerCommand = new SqlCommand(totalCustomerQuery, connection);
            var customerResult = customerCommand.ExecuteScalar();
            if (customerResult == DBNull.Value)
            {
                totalCustomer.Text = "0";
            }
            else
            {
                totalCustomer.Text = customerResult.ToString();
            }
            customerCommand.Dispose();

            var volunteerCommand = new SqlCommand(totalVolunteerQuery, connection);
            var volunteerResult = volunteerCommand.ExecuteScalar();
            if (volunteerResult == DBNull.Value)
            {
                totalVolunteer.Text = "0";
            }
            else
            {
                totalVolunteer.Text = volunteerResult.ToString();
            }
            volunteerCommand.Dispose();

            var employeeCommand = new SqlCommand(totalEmployeeQuery, connection);
            var employeeResult = employeeCommand.ExecuteScalar();
            if (employeeResult == DBNull.Value)
            {
                totalEmployee.Text = "0";
            }
            else
            {
                totalEmployee.Text = employeeResult.ToString();
            }
            employeeCommand.Dispose();

            var accessoriesCommand = new SqlCommand(totalAccessoriesQuery, connection);
            var accessoriesResult = accessoriesCommand.ExecuteScalar();
            if (accessoriesResult == DBNull.Value)
            {
                totalAccessories.Text = "0";
            }
            else
            {
                totalAccessories.Text = accessoriesResult.ToString();
            }
            accessoriesCommand.Dispose();

            var petsCommand = new SqlCommand(totalPetsQuery, connection);
            var petsResult = petsCommand.ExecuteScalar();
            if (petsResult == DBNull.Value)
            {
                totalPets.Text = "0";
            }
            else
            {
                totalPets.Text = petsResult.ToString();
            }
            petsCommand.Dispose();

            connection.Dispose();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            updata();
        }
    }
}
