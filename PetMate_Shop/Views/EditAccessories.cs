using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PetMate_Shop.Views;
using PetMate_Shop.Models;

namespace PetMate_Shop.Views
{
    public partial class EditAccessories : Form
    {
        private string _accessoryID;
        private string _name;
        private string _price;
        private string _suitableFor;
        private string _stock;
        private string _category;
        private string _brand;
        private byte[] _accessoriesImg;
        string _description;

        public EditAccessories(string accessoryID, string name, string price, string suitableFor, string stock, string category, string brand, byte[] accessoriesImg = null)
        {
            InitializeComponent();
            _accessoryID = accessoryID;
            _name = name;
            _price = price;
            _suitableFor = suitableFor;
            _stock = stock;
            _category = category;
            _brand = brand;
            _accessoriesImg = accessoriesImg;

            getDescription(_accessoryID);
            showDetails();
        }

        void getDescription(string accessoryID)
        {
            string query = "SELECT Description FROM Accessories WHERE AccessoryID = @AccessoryID";

            var connection = DatabaseConnection.GetConnection();
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccessoryID", accessoryID);

            connection.Open();
            var result = command.ExecuteScalar();

            if (result != null)
            {
                _description = result.ToString();
                descriptionTextTB.Text = _description;
            }
            else
            {
                descriptionTextTB.Text = "Description not available.";
            }
            command.Dispose();
            connection.Dispose();
        }

        private void showDetails()
        {
            accessoryIdValueLabel.Text = _accessoryID;
            lastUpdateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");

            nameTB.Text = _name;
            PriceTb.Text = _price;
            suitableForTB.Text = _suitableFor;
            availableTB.Text = _stock;
            categoryTB.Text = _category;
            brandTB.Text = _brand;

            if (_accessoriesImg != null)
            {
                var ms = new MemoryStream(_accessoriesImg);
                accessoryImg.Image = Image.FromStream(ms);
                ms.Dispose();
            }
            else
            {
                accessoryImg.Image = Properties.Resources.accessories_25;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addAccessoryImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                accessoryImg.Image = Image.FromFile(openFileDialog.FileName);

                var ms = new MemoryStream();
                accessoryImg.Image.Save(ms, accessoryImg.Image.RawFormat);
                _accessoriesImg = ms.ToArray();
                ms.Dispose();
            }
        }

        private void editAccessoryBtn_Click(object sender, EventArgs e)
        {
            string updatedName = nameTB.Text;
            string updatedPrice = PriceTb.Text;
            string updatedSuitableFor = suitableForTB.Text;
            string updatedStock = availableTB.Text;
            string updatedCategory = categoryTB.Text;
            string updatedBrand = brandTB.Text;

            UpdateAccessoryInDatabase(updatedName, updatedPrice, updatedSuitableFor, updatedStock, updatedCategory, updatedBrand, _accessoriesImg);
            this.Hide();
            MessageBox.Show("Accessory updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateAccessoryInDatabase(string name, string price, string suitableFor, string stock, string category, string brand, byte[] accessoriesImg)
        {
            string query = "UPDATE Accessories SET Name = @Name, Price = @Price, SuitableFor = @SuitableFor, " +
                           "Stock = @Stock, Category = @Category, Brand = @Brand, AccessoriesImg = @AccessoriesImg, UpdatedAt = @UpdatedAt " +
                           "WHERE AccessoryID = @AccessoryID";

            var connection = DatabaseConnection.GetConnection();
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@SuitableFor", suitableFor);
            command.Parameters.AddWithValue("@Stock", stock);
            command.Parameters.AddWithValue("@Category", category);
            command.Parameters.AddWithValue("@Brand", brand);
            command.Parameters.AddWithValue("@AccessoriesImg", accessoriesImg ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
            command.Parameters.AddWithValue("@AccessoryID", _accessoryID);

            connection.Open();
            command.ExecuteNonQuery();

            AccessoriesForm.instance.LoadAllData();
            command.Dispose();
            connection.Dispose();
        }
    }
}
