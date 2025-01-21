using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetMate_Shop.ComponentForms
{
    public partial class OrdersForms : UserControl
    {
        public static OrdersForms Instance;
        string _userName;
        string _role;

        public OrdersForms(string username, string role)
        {
            _userName = username;
            _role = role;
            InitializeComponent();
            Instance = this;
            LoadData();
        }

        public void LoadData()
        {
            odersLayoutPanel.Controls.Clear();

            string query = "SELECT DISTINCT co.CartID, co.CustomerID, u.HouseOrBuildingOrFlatNumber, u.StreetNameOrNumber, u.CityOrAreaName, u.PostalCode , u.Phone " +
                           "FROM CustomerOrder co " +
                           "JOIN Customer c ON co.CustomerID = c.CustomerID " +
                           "JOIN Users u ON c.UserName = u.UserName " +
                           "WHERE co.OrderStatus = 'Pending'";

            var connection = DatabaseConnection.GetConnection();
            var command = new SqlCommand(query, connection);
            connection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string cartId = reader["CartID"].ToString();
                string customerId = reader["CustomerID"].ToString();
                string houseBuildingFlatNumber = reader["HouseOrBuildingOrFlatNumber"].ToString();
                string streetNameNumber = reader["StreetNameOrNumber"].ToString();
                string cityAreaName = reader["CityOrAreaName"].ToString();
                string postalCode = reader["PostalCode"].ToString();
                string phnNumber = reader["Phone"].ToString();

                ShowOrder showOrderControl = new ShowOrder(cartId, customerId, houseBuildingFlatNumber, cityAreaName, streetNameNumber, postalCode, phnNumber);
                showOrderControl.LoadValues();
                odersLayoutPanel.Controls.Add(showOrderControl);
            }

            reader.Close();
            command.Dispose();
            connection.Dispose();
        }

        private void OrdersForms_Load(object sender, EventArgs e)
        {
            // Add any additional logic for form load if necessary
        }
    }
}
