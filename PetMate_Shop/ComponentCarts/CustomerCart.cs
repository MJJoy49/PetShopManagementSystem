using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PetMate_Shop.Views;

namespace PetMate_Shop.ComponentCarts
{
    public partial class CustomerCart : UserControl
    {
        private string _customerIdValue;
        private string _userNameValue;
        private int _totalPetBuyValue;
        private float _totalPurchaseValue;
        private UsersForm _recall;

        public CustomerCart(
            string customerIdValue,
            string userNameValue,
            UsersForm recall)
        {
            InitializeComponent();
            _customerIdValue = customerIdValue;
            _userNameValue = userNameValue;
            _recall = recall;

            LoadCustomerData();
            ShowData();
        }

        private void LoadCustomerData()
        {
            string query = @"
                SELECT 
                    COUNT(OrderID) AS TotalPetsBought,
                    ISNULL(SUM(TotalAmount), 0) AS TotalPurchaseAmount
                FROM CustomerOrder
                WHERE CustomerID = @CustomerID";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", _customerIdValue);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    _totalPetBuyValue = reader.GetInt32(0);
                    _totalPurchaseValue = (float)reader.GetDecimal(1);
                }
                reader.Close();
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowData()
        {
            customerIdValue.Text = _customerIdValue;
            userNameValue.Text = _userNameValue;
            totalPetBuyValue.Text = _totalPetBuyValue.ToString();
            totalPurchaseValue.Text = $"{_totalPurchaseValue:F2} tk";
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditCustomer editCustomer = new EditCustomer(
                _totalPurchaseValue.ToString(),
                _totalPetBuyValue.ToString(),
                _customerIdValue,
                _userNameValue,
                _recall
            );
            editCustomer.Show();
        }
    }
}
