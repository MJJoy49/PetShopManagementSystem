using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PetMate_Shop.Views;
using PetMate_Shop.Models;

namespace PetMate_Shop.ComponentCarts
{
    public partial class AccessoriesCart : UserControl
    {
        string _userName;
        string _accessoryID;
        string _name;
        string _price;
        string _suitableFor;
        string _stock;
        string _category;
        string _brand;
        byte[] _accessoriesImg;

        public AccessoriesCart(
            string userName,
            string accessoryID,
            string name,
            string price,
            string suitableFor,
            string stock,
            string category,
            string brand,
            byte[] accessoriesImg = null)
        {
            InitializeComponent();

            _userName = userName;
            _accessoryID = accessoryID;
            _name = name ;
            _price = price;
            _suitableFor = suitableFor;
            _stock = stock;
            _category = category;
            _brand = brand;
            _accessoriesImg = accessoriesImg;

            ShowDetails();
        }

        private void ShowDetails()
        {
            accessoryIdLabel.Text = _accessoryID;
            nameLabel.Text = _name;
            priceLabel.Text = _price;
            suitableForLabel.Text = _suitableFor;
            stockLabel.Text = _stock;
            brandLabel.Text = _brand;

            if (_accessoriesImg != null)
            {
                var ms = new MemoryStream(_accessoriesImg);
                accessoriesImg.Image = Image.FromStream(ms);
                ms.Dispose();
            }
            else
            {
                accessoriesImg.Image = Properties.Resources.accessories_25;
            }
        }

        private void addCartBtn_Click(object sender, EventArgs e)
        {
            string getCustomerIdQuery = "SELECT CustomerID FROM Customer WHERE UserName=@UserName";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(getCustomerIdQuery, connection);
            command.Parameters.AddWithValue("@UserName", MainForm.instance._userName);

            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                string customerId = sqlDataReader["CustomerID"].ToString();
                sqlDataReader.Close();

                string getActiveCartQuery = "SELECT CartID FROM AddCart WHERE CustomerID=@CustomerID AND CartStatus='Active' ORDER BY CartID DESC";
                string cartId = null;

                SqlCommand getCartCommand = new SqlCommand(getActiveCartQuery, connection);
                getCartCommand.Parameters.AddWithValue("@CustomerID", customerId);

                SqlDataReader cartReader = getCartCommand.ExecuteReader();
                if (cartReader.Read())
                {
                    cartId = cartReader["CartID"].ToString();
                }
                else
                {
                    cartId = IdCreator.GenerateId("AddCart", "CART", 2, 2);
                }

                cartReader.Close();

                string itemId = _accessoryID;
                string itemType = "accessory";
                int quantity = 1;

                AddToCart(cartId, customerId, itemId, itemType, quantity);

                MainForm.instance.totalAddcartvalue(_userName);
                AddCartForm.instance.createAddcartCart(_userName);
                AddCartForm.instance.totalPrice(_userName);
            }
            else
            {
                MessageBox.Show("No customer found for the provided username.");
            }

            command.Dispose();
            connection.Dispose();
        }

        private void AddToCart(string cartId, string customerId, string itemId, string itemType, int quantity)
        {
            string checkItemExistQuery = @"SELECT COUNT(*) FROM AddCart WHERE CartID = @CartID AND CustomerID = @CustomerID AND ItemID = @ItemID AND CartStatus = 'Active'";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();
            SqlCommand checkCommand = new SqlCommand(checkItemExistQuery, connection);
            checkCommand.Parameters.AddWithValue("@CartID", cartId);
            checkCommand.Parameters.AddWithValue("@CustomerID", customerId);
            checkCommand.Parameters.AddWithValue("@ItemID", itemId);

            int itemCount = (int)checkCommand.ExecuteScalar();
            if (itemCount > 0)
            {
                string updateItemQuery = @"UPDATE AddCart SET Quantity = Quantity + @Quantity WHERE CartID = @CartID AND CustomerID = @CustomerID AND ItemID = @ItemID";

                SqlCommand updateCommand = new SqlCommand(updateItemQuery, connection);
                updateCommand.Parameters.AddWithValue("@CartID", cartId);
                updateCommand.Parameters.AddWithValue("@CustomerID", customerId);
                updateCommand.Parameters.AddWithValue("@ItemID", itemId);
                updateCommand.Parameters.AddWithValue("@Quantity", quantity);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item quantity updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update item quantity.");
                }

                updateCommand.Dispose();
            }
            else
            {
                string addCartQuery = @"INSERT INTO AddCart (CartID, CustomerID, ItemID, ItemType, Quantity, AddedDate, CartStatus)
                                        VALUES (@CartID, @CustomerID, @ItemID, @ItemType, @Quantity, @AddedDate, 'Active')";

                SqlCommand insertCommand = new SqlCommand(addCartQuery, connection);
                insertCommand.Parameters.AddWithValue("@CartID", cartId);
                insertCommand.Parameters.AddWithValue("@CustomerID", customerId);
                insertCommand.Parameters.AddWithValue("@ItemID", itemId);
                insertCommand.Parameters.AddWithValue("@ItemType", itemType);
                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                insertCommand.Parameters.AddWithValue("@AddedDate", DateTime.Now);

                int rowsAffected = insertCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item added to cart successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add item to the cart.");
                }

                insertCommand.Dispose();
            }

            checkCommand.Dispose();
            connection.Dispose();
        }

        private void EditAccessoriesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EditAccessories editForm = new EditAccessories(
                    _accessoryID,
                    _name,
                    _price,
                    _suitableFor,
                    _stock,
                    _category,
                    _brand,
                    _accessoriesImg);

                editForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the edit form: {ex.Message}");
            }
        }

        private void AccessoriesCart_Load(object sender, EventArgs e)
        {
            if (MainForm.instance._role == "Employee" || MainForm.instance._role == "Admin")
            {
                EditAccessoriesBtn.Visible = true;
                editLabel.Visible = true;
                addCartBtn.Visible = false;
            }
        }
    }
}
