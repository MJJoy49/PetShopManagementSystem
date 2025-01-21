using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using PetMate_Shop.Models;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class AddAccessories : Form
    {
        public AddAccessories()
        {
            InitializeComponent();
        }

        private void AddAccessories_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addAccessoryBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTB.Text) || string.IsNullOrWhiteSpace(brandTB.Text) ||
                string.IsNullOrWhiteSpace(categoryTB.Text) || string.IsNullOrWhiteSpace(suitableForTB.Text) ||
                string.IsNullOrWhiteSpace(descriptionTextTB.Text) || string.IsNullOrWhiteSpace(availableTB.Text) ||
                string.IsNullOrWhiteSpace(PriceTb.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = nameTB.Text.Trim();
            string brand = brandTB.Text.Trim();
            string category = categoryTB.Text.Trim();
            string suitableFor = suitableForTB.Text.Trim();
            string description = descriptionTextTB.Text.Trim();
            int stock = int.TryParse(availableTB.Text.Trim(), out var stockResult) ? stockResult : -1;
            decimal price = decimal.TryParse(PriceTb.Text.Trim(), out var priceResult) ? priceResult : -1;

            if (stock < 0)
            {
                MessageBox.Show("Stock must be a valid non-negative number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("Price must be a valid non-negative number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] accessoryImgData = null;

            if (accessoryImg.Image != null)
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    accessoryImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    accessoryImgData = ms.ToArray();
                    ms.Dispose();
                }
                catch (Exception imgEx)
                {
                    MessageBox.Show($"Error processing image: {imgEx.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string accessoryID = IdCreator.GenerateId("Accessories", "AS", 3, 2);

            try
            {
                string insertQuery = @"
                    INSERT INTO Accessories (AccessoryID, Name, Price, Description, SuitableFor, Stock, Category, Brand, CreatedAt, UpdatedAt, AccessoriesImg)
                    VALUES (@AccessoryID, @Name, @Price, @Description, @SuitableFor, @Stock, @Category, @Brand, @CreatedAt, @UpdatedAt, @AccessoriesImg)";

                var connection = DatabaseConnection.GetConnection();
                connection.Open();
                var command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@AccessoryID", accessoryID);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@SuitableFor", suitableFor);
                command.Parameters.AddWithValue("@Stock", stock);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Brand", brand);
                command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                command.Parameters.AddWithValue("@AccessoriesImg", accessoryImgData ?? (object)DBNull.Value);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Accessory added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccessoriesForm.instance.LoadAllData();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to add accessory. Please try again.", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addAccessoryImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                Title = "Select Accessory Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    accessoryImg.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception imgEx)
                {
                    MessageBox.Show($"Error loading image: {imgEx.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
