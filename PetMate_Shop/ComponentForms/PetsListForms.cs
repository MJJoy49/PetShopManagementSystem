using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using PetMate_Shop.ComponentCarts;
using PetMate_Shop.Database;
using PetMate_Shop.Views;

namespace PetMate_Shop.ComponentForms
{
    public partial class PetsListForms : UserControl
    {
        string _userName;
        string _role;
        private int _sumOfAddFvt;
        string _searchTB;

        public PetsListForms(string username, string role)
        {
            _userName = username;
            _role = role;

            InitializeComponent();
            LoadItems();
            UpdateFavoritesCount();
        }

        private void addNewPetBtn_Click(object sender, EventArgs e)
        {
            AddPet addPet = new AddPet();
            addPet.FormClosed += (s, args) => LoadItems();
            addPet.Show();
        }

        public void LoadItems()
        {
            desplayPetPanel.Controls.Clear();

            string query = "SELECT TOP 10 PetID, Name, Gender, AgeRange, Price, PetImg FROM Pet ORDER BY PetID DESC";

            var connection = DatabaseConnection.GetConnection();
            var command = new SqlCommand(query, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string petId = reader["PetID"].ToString();
                string petName = reader["Name"].ToString();
                string petGender = reader["Gender"].ToString();
                string ageRange = reader["AgeRange"].ToString();
                string price = reader["Price"].ToString();
                byte[] petImg = reader["PetImg"] as byte[];

                var petCart = new PetCart(
                    _userName,
                    petName,
                    petId,
                    petGender,
                    ageRange,
                    price,
                    petImg,
                    this
                )
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

                desplayPetPanel.Controls.Add(petCart);
            }

            reader.Close();
            command.Dispose();
            connection.Dispose();
        }

        public void UpdateFavoritesCount()
        {
            string query = "SELECT COUNT(*) FROM AddFavourite WHERE UserName = @UserName";

            var connection = DatabaseConnection.GetConnection();
            var command = new SqlCommand(query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@UserName", _userName);
            _sumOfAddFvt = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Dispose();

            sumOfAddFvt.Text = _sumOfAddFvt.ToString();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            _searchTB = searchTB.Text.Trim();
            LoadItems(_searchTB);
        }

        private void LoadItems(string searchTerm = "")
        {
            if (searchTerm == "")
            {
                return;
            }
            else
            {
                desplayPetPanel.Controls.Clear();

                string query = "SELECT TOP 10 PetID, Name, Gender, AgeRange, Price, PetImg FROM Pet WHERE AgeRange LIKE @SearchTerm OR Price LIKE @SearchTerm OR PetID LIKE @SearchTerm OR Name LIKE @SearchTerm OR Type LIKE @SearchTerm OR Gender LIKE @SearchTerm ORDER BY PetID DESC";

                var connection = DatabaseConnection.GetConnection();
                var command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string petId = reader["PetID"].ToString();
                    string petName = reader["Name"].ToString();
                    string petGender = reader["Gender"].ToString();
                    string ageRange = reader["AgeRange"].ToString();
                    string price = reader["Price"].ToString();
                    byte[] petImg = reader["PetImg"] as byte[];

                    var petCart = new PetCart(
                        _userName,
                        petName,
                        petId,
                        petGender,
                        ageRange,
                        price,
                        petImg,
                        this
                    )
                    {
                        Dock = DockStyle.Top,
                        Margin = new Padding(10)
                    };

                    desplayPetPanel.Controls.Add(petCart);
                }

                reader.Close();
                command.Dispose();
                connection.Dispose();

                searchTB.Text = "";
            }
        }

        private void allPetBtn_Click(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void fvtBtn_Click(object sender, EventArgs e)
        {
            desplayPetPanel.Controls.Clear();

            string query = @"SELECT p.PetID, p.Name, p.Gender, p.AgeRange, p.Price, p.PetImg FROM Pet p
                                INNER JOIN AddFavourite af ON p.PetID = af.PetID
                                WHERE af.UserName = @UserName";

            var connection = DatabaseConnection.GetConnection();
            var command = new SqlCommand(query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@UserName", _userName);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string petId = reader["PetID"].ToString();
                string petName = reader["Name"].ToString();
                string petGender = reader["Gender"].ToString();
                string ageRange = reader["AgeRange"].ToString();
                string price = reader["Price"].ToString();
                byte[] petImg = reader["PetImg"] as byte[];

                var petCart = new PetCart(
                    _userName,
                    petName,
                    petId,
                    petGender,
                    ageRange,
                    price,
                    petImg,
                    this
                )
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

                desplayPetPanel.Controls.Add(petCart);
            }

            reader.Close();
            command.Dispose();
            connection.Dispose();
        }

        private void PetsListForms_Load(object sender, EventArgs e)
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
