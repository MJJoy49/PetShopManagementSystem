using PetMate_Shop.ComponentCarts;
using PetMate_Shop.Database;
using PetMate_Shop.Models;
using PetMate_Shop.Views;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetMate_Shop.ComponentForms
{
    public partial class AddCartForm : UserControl
    {
        public static AddCartForm instance;
        string _userName;
        string _customerID;
        string _totalPriceValue;
        string _role;

        public AddCartForm(string userName, string role)
        {
            _userName = userName;
            _role = role;
            InitializeComponent();
            createAddcartCart(userName);
            totalPrice(userName);
            instance = this;
        }

        public void totalPrice(string userName)
        {
            string getCustomerIdQuery = "SELECT CustomerID FROM Customer WHERE UserName=@UserName";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();
            var command = new SqlCommand(getCustomerIdQuery, connection);
            command.Parameters.AddWithValue("@UserName", userName);

            var sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string customerId = sqlDataReader["CustomerID"].ToString();
                sqlDataReader.Close();

                string totalPriceQuery = @"
                        SELECT SUM(CASE 
                                    WHEN ac.ItemType = 'pet' THEN p.Price * ac.Quantity
                                    WHEN ac.ItemType = 'accessory' THEN a.Price * ac.Quantity
                                    ELSE 0
                                END) AS TotalPrice
                        FROM AddCart ac
                        LEFT JOIN Pet p ON ac.ItemID = p.PetID AND ac.ItemType = 'pet'
                        LEFT JOIN Accessories a ON ac.ItemID = a.AccessoryID AND ac.ItemType = 'accessory'
                        WHERE ac.CustomerID = @CustomerID AND ac.CartStatus = 'Active'";

                var totalPriceCommand = new SqlCommand(totalPriceQuery, connection);
                totalPriceCommand.Parameters.AddWithValue("@CustomerID", customerId);

                var result = totalPriceCommand.ExecuteScalar();
                decimal totalPrice = result != DBNull.Value && result != null ? Convert.ToDecimal(result) : 0;

                _totalPriceValue = totalPrice.ToString("0.00");
                totalPriceValue.Text = _totalPriceValue + " tk";
                totalPriceCommand.Dispose();
            }
            else
            {
                command.Dispose();
                connection.Dispose();
                return;
            }
            command.Dispose();
            connection.Dispose();
        }

        public void createAddcartCart(string userName)
        {
            var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string getCustomerQuery = "SELECT CustomerID FROM Customer WHERE UserName = @UserName";
            string customerId = null;

            var customerCommand = new SqlCommand(getCustomerQuery, connection);
            customerCommand.Parameters.AddWithValue("@UserName", userName);

            var reader = customerCommand.ExecuteReader();
            if (reader.Read())
            {
                customerId = reader["CustomerID"].ToString();
                _customerID = customerId;
            }
            reader.Close();
            customerCommand.Dispose();

            if (string.IsNullOrEmpty(customerId))
            {
                connection.Dispose();
                return;
            }

            string getCartQuery = "SELECT CartID, CustomerID, ItemID, ItemType, Quantity FROM AddCart WHERE CustomerID = @CustomerID AND CartStatus = 'Active'";

            var cartCommand = new SqlCommand(getCartQuery, connection);
            cartCommand.Parameters.AddWithValue("@CustomerID", customerId);

            var cartReader = cartCommand.ExecuteReader();
            AddCartDataFlowLayout.Controls.Clear();

            while (cartReader.Read())
            {
                AddCart_Cart addCartControl = new AddCart_Cart(
                    _userName,
                    cartReader["CartID"].ToString(),
                    cartReader["CustomerID"].ToString(),
                    cartReader["ItemID"].ToString(),
                    cartReader["ItemType"].ToString(),
                    Convert.ToInt32(cartReader["Quantity"])
                );

                AddCartDataFlowLayout.Controls.Add(addCartControl);
            }
            cartReader.Close();
            cartCommand.Dispose();
            connection.Dispose();
        }

        private void AddCartForm_Load(object sender, EventArgs e)
        {

        }

        private void OrderConfirmBtn_Click(object sender, EventArgs e)
        {
            PaymentMethod paymentMethod = new PaymentMethod(_totalPriceValue, _customerID);
            paymentMethod.Show();
        }
    }
}
