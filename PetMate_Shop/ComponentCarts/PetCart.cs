using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PetMate_Shop.Views;
using PetMate_Shop.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection;

namespace PetMate_Shop.ComponentCarts
{
    public partial class PetCart : UserControl
    {
        private string _userName;
        private string _petNameValue;
        private string _petIdValue;
        private string _petGenderValue;
        private string _ageRangeValue;
        private string _petPriceValue;
        private byte[] _petImg;
        PetsListForms recall;

        public PetCart(
                        string userName,
                        string petNameValue,
                        string petIdValue,
                        string petGenderValue,
                        string ageRangeValue,
                        string petPriceValue,
                        byte[] petImg,
                        PetsListForms recall
            )
        {
            InitializeComponent();

            _userName = userName;
            _petNameValue = petNameValue;
            _petIdValue = petIdValue;
            _petGenderValue = petGenderValue;
            _ageRangeValue = ageRangeValue;
            _petPriceValue = petPriceValue;
            _petImg = petImg;
            this.recall = recall;

            AddInfo();
        }

        public void AddInfo()
        {
            petNameValue.Text = _petNameValue;
            petIdValue.Text = _petIdValue;
            petGenderValue.Text = _petGenderValue;
            ageRangeValue.Text = _ageRangeValue;
            petPriceValue.Text = $"{_petPriceValue} tk";

            if (_petImg != null)
            {
                using (var ms = new MemoryStream(_petImg))
                {
                    petImg.Image = Image.FromStream(ms);
                }
            }
            else
            {
                petImg.Image = Properties.Resources.pet_30;
            }
        }

        private void CheckAndSetFavoriteStatus()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM AddFavourite WHERE UserName = @UserName AND PetID = @PetID";

                var connection = DatabaseConnection.GetConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", _userName);
                command.Parameters.AddWithValue("@PetID", _petIdValue);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    addFvtBtn.Image = Properties.Resources.star_30;
                }
                else
                {
                    addFvtBtn.Image = Properties.Resources.add_favorite_30;
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking favorite status: {ex.Message}");
            }
        }

        private void ToggleFavoriteStatus()
        {
            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM AddFavourite WHERE UserName = @UserName AND PetID = @PetID";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@UserName", _userName);
                checkCommand.Parameters.AddWithValue("@PetID", _petIdValue);

                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    string deleteQuery = "DELETE FROM AddFavourite WHERE UserName = @UserName AND PetID = @PetID";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@UserName", _userName);
                    deleteCommand.Parameters.AddWithValue("@PetID", _petIdValue);
                    deleteCommand.ExecuteNonQuery();

                    addFvtBtn.Image = Properties.Resources.add_favorite_30;
                    if (recall != null)
                    {
                        recall.UpdateFavoritesCount();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update favorites count, recall is not initialized.");
                    }
                    CheckAndSetFavoriteStatus();
                }
                else
                {
                    string insertQuery = @"
                        INSERT INTO AddFavourite (FavouriteID, UserName, PetID, AddedDate)
                        VALUES (@FavouriteID, @UserName, @PetID, @AddedDate)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@FavouriteID", Guid.NewGuid().ToString());
                    insertCommand.Parameters.AddWithValue("@UserName", _userName);
                    insertCommand.Parameters.AddWithValue("@PetID", _petIdValue);
                    insertCommand.Parameters.AddWithValue("@AddedDate", DateTime.Now);
                    insertCommand.ExecuteNonQuery();

                    addFvtBtn.Image = Properties.Resources.star_30;
                    if (recall != null)
                    {
                        recall.UpdateFavoritesCount();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update favorites count, recall is not initialized.");
                    }
                    CheckAndSetFavoriteStatus();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error toggling favorite status: {ex.Message}");
            }
        }

        private void addFvtBtn_DoubleClick(object sender, EventArgs e)
        {
            ToggleFavoriteStatus();
        }

        private void PetCart_Load(object sender, EventArgs e)
        {
            CheckAndSetFavoriteStatus();
            if (MainForm.instance._role == "Employee" || MainForm.instance._role == "Admin")
            {
                profileInfoEditBtn.Visible = true;
                editLabel.Visible = true;

                addCartBtn.Visible = false;
            }
        }

        private void addFvtBtn_Click(object sender, EventArgs e)
        {
        }

        private void profileInfoEditBtn_Click(object sender, EventArgs e)
        {
            EditPet editPet = new EditPet(
                recall,
                _petImg,
                _ageRangeValue,
                _petIdValue,
                _petNameValue,
                _petPriceValue
            );
            editPet.Show();
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

                string itemId = _petIdValue;
                string itemType = "pet";
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

            connection.Close();
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
                    MessageBox.Show("Failed to add item to cart.");
                }
            }

            connection.Close();
        }
    }
}
