using PetMate_Shop.Database;
using PetMate_Shop.Models;
using PetMate_Shop.Views;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetMate_Shop.ComponentForms
{
    public partial class ShowOrder : UserControl
    {
        string _cartId;
        string _customerId;
        string _houseBuildingFlatNumber;
        string _cityAreaName;
        string _streetNameNumber;
        string _postalCode;
        string _phnNumberValue;

        public ShowOrder(string cartId, string customerId,
                         string houseBuildingFlatNumber, string cityAreaName,
                         string streetNameNumber, string postalCode, string phnNumberValue)
        {
            InitializeComponent();
            _cartId = cartId;
            _customerId = customerId;
            _houseBuildingFlatNumber = houseBuildingFlatNumber;
            _cityAreaName = cityAreaName;
            _streetNameNumber = streetNameNumber;
            _postalCode = postalCode;
            _phnNumberValue = phnNumberValue;
        }

        public void LoadValues()
        {
            customerIdLabel.Text = _customerId;
            houseBuildingFlatNumberValue.Text = _houseBuildingFlatNumber;
            cityAreaNameValue.Text = _cityAreaName;
            streetNameNumberValue.Text = _streetNameNumber;
            postalCodeValue.Text = _postalCode;
            paymentMathod.Text = getPaymentMethod(_cartId, _customerId);
            phnNumberValue.Text = _phnNumberValue;

            LoadOrderItems();
        }

        private string getPaymentMethod(string cardId, string customerId)
        {
            string paymentMethod = string.Empty;

            string query = "SELECT p.PaymentMethod " +
                           "FROM Payment p " +
                           "JOIN CustomerOrder co ON p.OrderID = co.OrderID " +
                           "JOIN AddCart ac ON co.CartID = ac.CartID " +
                           "WHERE ac.CustomerID = @CustomerID " +
                           "AND ac.CartID = @CartID;";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                command.Parameters.AddWithValue("@CartID", cardId);

                connection.Open();
                var result = command.ExecuteScalar();

                if (result != null)
                {
                    paymentMethod = result.ToString();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return paymentMethod;
        }

        private void LoadOrderItems()
        {
            itemAndQuantityLayoutPanel.Controls.Clear();

            string query = "SELECT ItemID, Quantity FROM AddCart WHERE CartID = @CartID AND CartStatus = 'Closed'";

            var connection = DatabaseConnection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CartID", _cartId);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string itemId = reader["ItemID"].ToString();
                string quantity = reader["Quantity"].ToString();

                OrderItems orderItemControl = new OrderItems(itemId, quantity);
                itemAndQuantityLayoutPanel.Controls.Add(orderItemControl);
            }

            reader.Close();
            connection.Close();
        }

        private SqlDataReader GetPetData()
        {
            string query = @"
                    SELECT ac.ItemID, p.PetID, p.Price 
                    FROM AddCart ac
                    JOIN Pet p ON ac.ItemID = p.PetID
                    WHERE ac.CartID = @CartID AND ac.CustomerID = @CustomerID AND ac.CartStatus = 'Closed'";

            var connection = DatabaseConnection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CartID", _cartId);
            command.Parameters.AddWithValue("@CustomerID", _customerId);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        private void InsertBuyPetRecord()
        {
            SqlDataReader reader = GetPetData();

            try
            {
                while (reader.Read())
                {
                    string itemId = reader["ItemID"].ToString();
                    decimal price = Convert.ToDecimal(reader["Price"]);

                    if (IsPetIdValid(itemId))
                    {
                        string buyPetId = IdCreator.GenerateId("BuyPet", "BPI", 2, 2);
                        string adoptionRequestId = "No adopted";
                        DateTime purchaseDate = DateTime.Now;

                        InsertBuyPet(buyPetId, itemId, price, adoptionRequestId, purchaseDate);
                    }
                }
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
        }

        private void InsertBuyPet(string buyPetId, string petId, decimal price, string adoptedBy, DateTime purchaseDate)
        {
            string insertQuery = @"
                           INSERT INTO BuyPet (BuyPetID, CustomerID, PetID, AdoptedBy, PurchaseDate, Price)
                           VALUES (@BuyPetID, @CustomerID, @PetID, @AdoptedBy, @PurchaseDate, @Price)";

            var connection = DatabaseConnection.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.Parameters.AddWithValue("@BuyPetID", buyPetId);
            insertCommand.Parameters.AddWithValue("@CustomerID", _customerId);
            insertCommand.Parameters.AddWithValue("@PetID", petId);
            insertCommand.Parameters.AddWithValue("@AdoptedBy", adoptedBy);
            insertCommand.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
            insertCommand.Parameters.AddWithValue("@Price", price);

            connection.Open();
            insertCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void deliveryOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string updateOrderQuery = @"
                UPDATE CustomerOrder
                SET OrderStatus = 'delivery'
                WHERE OrderStatus = 'pending' 
                  AND CartID = @CartID
                  AND CustomerID = @CustomerID;";

                var command = new SqlCommand(updateOrderQuery, connection);
                command.Parameters.AddWithValue("@CartID", _cartId);
                command.Parameters.AddWithValue("@CustomerID", _customerId);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} orders updated to 'delivery' status.");

                string updatePaymentQuery = @"
                UPDATE Payment
                SET PaymentStatus = 'Completed'
                WHERE PaymentStatus = 'Pending' 
                  AND CustomerID = @CustomerID 
                  AND OrderID IN (SELECT OrderID FROM CustomerOrder WHERE CartID = @CartID);";

                command = new SqlCommand(updatePaymentQuery, connection);
                command.Parameters.AddWithValue("@CartID", _cartId);
                command.Parameters.AddWithValue("@CustomerID", _customerId);

                rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} payments updated to 'Completed' status.");

                InsertBuyPetRecord();
                OrdersForms.Instance.LoadData();
                connection.Close();
                MakeNotification.AddNotification(DatabaseHelper.GetCustomerUsername(_customerId), $"{_customerId} your order has been delivered");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private bool IsPetIdValid(string ItemId)
        {
            bool isValid = false;

            string query = "SELECT COUNT(*) FROM Pet WHERE PetID = @PetID";
            var connection = DatabaseConnection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PetID", ItemId);

            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                isValid = count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while validating PetID: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return isValid;
        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            string fetchOrderQuery = @"
                                        SELECT OrderID
                                        FROM CustomerOrder
                                        WHERE CustomerID = @CustomerID AND CartID = @CartID";

            string orderId = string.Empty;

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                SqlCommand fetchCommand = new SqlCommand(fetchOrderQuery, connection);
                fetchCommand.Parameters.AddWithValue("@CustomerID", _customerId);
                fetchCommand.Parameters.AddWithValue("@CartID", _cartId);

                SqlDataReader reader = fetchCommand.ExecuteReader();
                if (reader.Read())
                {
                    orderId = reader.GetString(0);
                }
                reader.Close();

                if (string.IsNullOrEmpty(orderId))
                {
                    MessageBox.Show("Order not found for this customer and cart.");
                    return;
                }

                string updateOrderQuery = @"
                                                UPDATE CustomerOrder
                                                SET OrderStatus = 'cancel', TotalAmount = 0
                                                WHERE OrderID = @OrderID AND CustomerID = @CustomerID";

                SqlCommand updateCommand = new SqlCommand(updateOrderQuery, connection);
                updateCommand.Parameters.AddWithValue("@OrderID", orderId);
                updateCommand.Parameters.AddWithValue("@CustomerID", _customerId);
                updateCommand.ExecuteNonQuery();

                string selectItemsQuery = @"
                                                SELECT ItemID, Quantity, ItemType
                                                FROM AddCart
                                                WHERE CartID = @CartID AND CustomerID = @CustomerID AND CartStatus = 'Closed'";

                SqlCommand selectCommand = new SqlCommand(selectItemsQuery, connection);
                selectCommand.Parameters.AddWithValue("@CartID", _cartId);
                selectCommand.Parameters.AddWithValue("@CustomerID", _customerId);

                reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    string itemType = reader["ItemType"].ToString();
                    int quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                    string itemId = reader.GetString(reader.GetOrdinal("ItemID"));

                    if (itemType == "Pet")
                    {
                        UpdatePetStock(itemId, quantity);
                    }
                    else
                    {
                        UpdateAccessoryStock(itemId, quantity);
                    }
                }

                reader.Close();

                string updateCartQuery = "UPDATE AddCart SET CartStatus = 'cancel' WHERE CartID = @CartID";
                SqlCommand updateCartCommand = new SqlCommand(updateCartQuery, connection);
                updateCartCommand.Parameters.AddWithValue("@CartID", _cartId);
                updateCartCommand.ExecuteNonQuery();

                OrdersForms.Instance.LoadData();
                MakeNotification.AddNotification(DatabaseHelper.GetCustomerUsername(_customerId), $"{_customerId} your order has been cancelled");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void UpdatePetStock(string petId, int quantity)
        {
            string query = "UPDATE Pet SET Stock = Stock + @Quantity WHERE PetID = @PetID";
            UpdateStock(query, petId, quantity);
        }

        private void UpdateAccessoryStock(string accessoryId, int quantity)
        {
            string query = "UPDATE Accessories SET Stock = Stock + @Quantity WHERE AccessoryID = @AccessoryID";
            UpdateStock(query, accessoryId, quantity);
        }

        private void UpdateStock(string query, string id, int quantity)
        {
            var connection = DatabaseConnection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@PetID", id);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating stock: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
