using PetMate_Shop.ComponentCarts;
using PetMate_Shop.Database;
using PetMate_Shop.Views;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetMate_Shop.ComponentForms
{
    public partial class AccessoriesForm : UserControl
    {
        public static AccessoriesForm instance;

        string _userName;
        string _role;

        public AccessoriesForm(string userName, string role)
        {
            InitializeComponent();
            _userName = userName;
            _role = role;
            instance = this;
            LoadAllData();
        }

        public void LoadAllData(string category = null, string searchValue = null)
        {
            string query;

            if (!string.IsNullOrEmpty(category))
            {
                query = "SELECT * FROM Accessories WHERE Category = @Category";
            }
            else if (!string.IsNullOrEmpty(searchValue))
            {
                query = "SELECT * FROM Accessories WHERE Name LIKE @Search OR Brand LIKE @Search";
            }
            else
            {
                query = "SELECT * FROM Accessories";
            }

            var connection = DatabaseConnection.GetConnection();
            connection.Open();
            var command = new SqlCommand(query, connection);
            if (!string.IsNullOrEmpty(category))
                command.Parameters.AddWithValue("@Category", category);

            if (!string.IsNullOrEmpty(searchValue))
                command.Parameters.AddWithValue("@Search", $"%{searchValue}%");

            var reader = command.ExecuteReader();
            desplayAccessoriesPanel.Controls.Clear();

            while (reader.Read())
            {
                string accessoryID = reader["AccessoryID"].ToString();
                string name = reader["Name"].ToString();
                string price = reader["Price"].ToString();
                string suitableFor = reader["SuitableFor"].ToString();
                string stock = reader["Stock"].ToString();
                string categoryValue = reader["Category"].ToString();
                string brand = reader["Brand"].ToString();
                byte[] accessoriesImg = reader["AccessoriesImg"] as byte[];

                var accessory = new AccessoriesCart(
                    _userName,
                    accessoryID,
                    name,
                    price,
                    suitableFor,
                    stock,
                    categoryValue,
                    brand,
                    accessoriesImg
                );

                desplayAccessoriesPanel.Controls.Add(accessory);
            }

            reader.Close();
            command.Dispose();
            connection.Dispose();
        }

        private void foodCatagoryBtn_Click(object sender, EventArgs e)
        {
            LoadAllData(category: "food");
        }

        private void medicineCatagoryBtn_Click(object sender, EventArgs e)
        {
            LoadAllData(category: "medicine");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a value to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadAllData(searchValue: searchValue);
        }

        private void allAccessoriesBtn_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void addNewPetBtn_Click(object sender, EventArgs e)
        {
            var addAccessories = new AddAccessories();
            addAccessories.Show();
        }

        private void AccessoriesForm_Load(object sender, EventArgs e)
        {
            if (_role == "Customer")
            {
                AddNewItemPanel.Visible = false;
            }
            else if (_role == "Employee" || _role == "Admin")
            {
                AddNewItemPanel.Visible = true;
            }
        }
    }
}
