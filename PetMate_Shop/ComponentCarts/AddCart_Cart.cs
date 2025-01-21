using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using PetMate_Shop.Models;
using PetMate_Shop.Views;

namespace PetMate_Shop.ComponentCarts
{
    public partial class AddCart_Cart : UserControl
    {
        private string _cartId;
        private string _customerId;
        private string _catagory;
        private string _itemId;
        private string _itemType;
        private int _quantity;
        private string _price;
        private string _userName;

        public AddCart_Cart(
            string userName,
            string cartId,
            string customerId,
            string itemId,
            string itemType,
            int quantity
        )
        {
            InitializeComponent();
            _userName = userName;
            _cartId = cartId;
            _customerId = customerId;
            _itemId = itemId;
            _itemType = itemType;
            _quantity = quantity;
            getPrice(itemId);
            Catagory(itemId, itemType);
            GetCustomerId(userName);
            AddInfo();
        }

        void getPrice(string itemId)
        {
            decimal price = 0;

            string getPriceQuery = @"
                                        SELECT 
                                            CASE 
                                                WHEN ac.ItemType = 'pet' THEN p.Price
                                                WHEN ac.ItemType = 'accessory' THEN a.Price
                                                ELSE 0
                                            END AS Price
                                        FROM AddCart ac
                                        LEFT JOIN Pet p ON ac.ItemID = p.PetID AND ac.ItemType = 'pet'
                                        LEFT JOIN Accessories a ON ac.ItemID = a.AccessoryID AND ac.ItemType = 'accessory'
                                        WHERE ac.ItemID = @ItemID";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(getPriceQuery, connection);
            command.Parameters.AddWithValue("@ItemID", itemId);
            var result = command.ExecuteScalar();
            price = Convert.ToDecimal(result);
            _price = price.ToString();
            connection.Close();
        }

        private void AddInfo()
        {
            itemIdValue.Text = _itemId;
            ItemTypeValue.Text = _itemType;
            ItemCatagoryValue.Text = _catagory;
            priceValue.Text = _price + " tk";
            quantityValue.Text = _quantity.ToString();
        }

        private void Catagory(string itemId, string itemType)
        {
            string query = "";
            if (itemType == "pet")
            {
                query = "SELECT Type FROM Pet WHERE PetID = @ItemId";
            }
            else if (itemType == "accessory")
            {
                query = "SELECT Category FROM Accessories WHERE AccessoryID = @ItemId";
            }
            else
            {
                MessageBox.Show("Invalid item type!");
                return;
            }

            var connection = DatabaseConnection.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemId", itemId);
            var result = command.ExecuteScalar();
            if (result != null)
            {
                string typeValue = result.ToString();
                _catagory = typeValue;
            }
            else
            {
                MessageBox.Show("Item not found!");
            }
            connection.Close();
        }

        private void DeleteToAddCartBtn_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM AddCart WHERE CartID = @CartID";
            var connection = DatabaseConnection.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@CartID", _cartId);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item deleted successfully from the cart.");
                    MainForm.instance.totalAddcartvalue(_userName);
                    AddCartForm.instance.createAddcartCart(_userName);
                    AddCartForm.instance.totalPrice(_userName);
                }
                else
                {
                    MessageBox.Show("No item found to delete.");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the item: " + ex.Message);
            }
        }

        private void quantityUpBtn_Click(object sender, EventArgs e)
        {
            UpdateQuantity(1);
            MainForm.instance.totalAddcartvalue(_userName);
            AddCartForm.instance.totalPrice(_userName);
        }

        private void quantityDownValue_Click(object sender, EventArgs e)
        {
            UpdateQuantity(-1);
            MainForm.instance.totalAddcartvalue(_userName);
            AddCartForm.instance.totalPrice(_userName);
        }

        private void UpdateQuantity(int change)
        {
            if (string.IsNullOrEmpty(_customerId))
            {
                MessageBox.Show("Customer not found!");
                return;
            }

            if (string.IsNullOrEmpty(_itemId) || string.IsNullOrEmpty(_itemType))
            {
                MessageBox.Show("Item ID or Item Type is not provided!");
                return;
            }

            string stockQuery = _itemType.ToLower() == "pet"
                ? "SELECT Stock FROM Pet WHERE PetID = @ItemID"
                : "SELECT Stock FROM Accessories WHERE AccessoryID = @ItemID";

            string updateQuery = @"
                                    UPDATE AddCart
                                    SET Quantity = CASE
                                        WHEN Quantity + @Change <= @MaxStock AND Quantity + @Change >= 1 THEN Quantity + @Change
                                        WHEN Quantity + @Change > @MaxStock THEN @MaxStock
                                        ELSE 1
                                    END
                                    WHERE CustomerID = @CustomerID AND ItemID = @ItemID";

            string getQuantityQuery = @"
                                    SELECT Quantity
                                    FROM AddCart
                                    WHERE CustomerID = @CustomerID AND ItemID = @ItemID";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();
            SqlCommand stockCommand = new SqlCommand(stockQuery, connection);
            stockCommand.Parameters.AddWithValue("@ItemID", _itemId);
            object stockResult = stockCommand.ExecuteScalar();

            if (stockResult == null)
            {
                MessageBox.Show("Item not found in the stock table!");
                return;
            }

            int maxStock = Convert.ToInt32(stockResult);

            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@Change", change);
            updateCommand.Parameters.AddWithValue("@MaxStock", maxStock);
            updateCommand.Parameters.AddWithValue("@CustomerID", _customerId);
            updateCommand.Parameters.AddWithValue("@ItemID", _itemId);

            int rowsAffected = updateCommand.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                SqlCommand getQuantityCommand = new SqlCommand(getQuantityQuery, connection);
                getQuantityCommand.Parameters.AddWithValue("@CustomerID", _customerId);
                getQuantityCommand.Parameters.AddWithValue("@ItemID", _itemId);

                object updatedQuantity = getQuantityCommand.ExecuteScalar();
                if (updatedQuantity != null)
                {
                    quantityValue.Text = updatedQuantity.ToString();
                }
                else
                {
                    MessageBox.Show("Failed to retrieve updated quantity.");
                }
            }
            else
            {
                MessageBox.Show("Failed to update quantity. Item might not exist in the cart.");
            }
            connection.Close();
        }

        private void GetCustomerId(string userName)
        {
            string query = "SELECT CustomerID FROM Customer WHERE UserName = @UserName";
            var connection = DatabaseConnection.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", userName);
            var result = command.ExecuteScalar();
            _customerId = result.ToString();
            connection.Close();
        }

        private void AddCart_Cart_Load(object sender, EventArgs e)
        {
        }
    }
}
