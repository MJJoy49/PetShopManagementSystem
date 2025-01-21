using PetMate_Shop.ComponentCarts;
using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class EditPet : Form
    {
        string _petIdValue;
        string _petNameValue;
        string _petTypeValue;
        string _petBreedValue;
        string _descriptionText;
        string _petPriceValue;
        int _petAvailableValue;
        string _petAgeRangeValue;
        string _petHealthStatus;
        byte[] _petImg;

        PetsListForms recall;

        public EditPet(PetsListForms petCart, byte[] petImg, string petAgeRangeValue, string petIdValue, string petNameValue, string petPriceValue)
        {
            InitializeComponent();
            this.recall = petCart;
            _petImg = petImg;
            _petIdValue = petIdValue;
            _petNameValue = petNameValue;
            _petPriceValue = petPriceValue;
            _petAgeRangeValue = petAgeRangeValue;

            showData();
        }

        void showData()
        {
            petIdValue.Text = _petIdValue;
            petNameValue.Text = _petNameValue;
            petPriceValue.Text = _petPriceValue.ToString();
            petAvailableValue.Text = _petAvailableValue.ToString();
            descriptionText.Text = _descriptionText;

            if (_petImg != null)
            {
                var ms = new MemoryStream(_petImg);
                petImg.Image = Image.FromStream(ms);
                ms.Dispose();
            }

            LoadPetAdditionalData();
        }

        void LoadPetAdditionalData()
        {
            try
            {
                string query = "SELECT Type, Breed, Gender, HealthStatus, Stock, Description, AgeRange FROM Pet WHERE PetID = @PetID";

                var connection = DatabaseConnection.GetConnection();
                connection.Open();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PetID", _petIdValue);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    petTypeValue.Text = reader["Type"].ToString();
                    petBreedValue.Text = reader["Breed"].ToString();
                    descriptionText.Text = reader["Description"].ToString();
                    petAvailableValue.Text = reader["Stock"].ToString();

                    string gender = reader["Gender"].ToString();
                    if (gender == "Male")
                        maleR.Checked = true;
                    else if (gender == "Female")
                        femaleR.Checked = true;

                    string healthStatus = reader["HealthStatus"].ToString();
                    if (healthStatus == "Fully Vaccinated")
                        fullyVR.Checked = true;
                    else if (healthStatus == "Partially Vaccinated")
                        partialyVR.Checked = true;
                    else if (healthStatus == "Not Vaccinated")
                        noVR.Checked = true;

                    string ageRange = reader["AgeRange"].ToString();
                    if (ageRange == "Puppy")
                        puppyR.Checked = true;
                    else if (ageRange == "Kitten")
                        kittenR.Checked = true;
                    else if (ageRange == "Adult")
                        adultR.Checked = true;
                }

                reader.Close();
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading pet details: {ex.Message}");
            }
        }

        private void editPetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(petNameValue.Text) ||
                    string.IsNullOrWhiteSpace(petTypeValue.Text) ||
                    (!maleR.Checked && !femaleR.Checked) ||
                    string.IsNullOrWhiteSpace(petBreedValue.Text) ||
                    string.IsNullOrWhiteSpace(petPriceValue.Text) || !decimal.TryParse(petPriceValue.Text, out decimal price) || price <= 0 ||
                    string.IsNullOrWhiteSpace(descriptionText.Text) ||
                    string.IsNullOrWhiteSpace(petAvailableValue.Text) || !int.TryParse(petAvailableValue.Text, out int stock) || stock < 0 ||
                    (!fullyVR.Checked && !partialyVR.Checked && !noVR.Checked) ||
                    (!puppyR.Checked && !kittenR.Checked && !adultR.Checked))
                {
                    MessageBox.Show("Please ensure all fields are filled in correctly.");
                    return;
                }

                string gender = maleR.Checked ? "Male" : "Female";
                string healthStatus = fullyVR.Checked ? "Fully Vaccinated" :
                                      partialyVR.Checked ? "Partially Vaccinated" :
                                      "Not Vaccinated";
                string ageRange = puppyR.Checked ? "Puppy" :
                                  kittenR.Checked ? "Kitten" :
                                  "Adult";

                string updateQuery = @"
                UPDATE Pet
                SET Name = @Name, Type = @Type, Gender = @Gender, Breed = @Breed, Price = @Price, Description = @Description,
                    AgeRange = @AgeRange, Stock = @Stock, HealthStatus = @HealthStatus, PetImg = @PetImg
                WHERE PetID = @PetID";

                var connection = DatabaseConnection.GetConnection();
                connection.Open();
                var command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@PetID", _petIdValue);
                command.Parameters.AddWithValue("@Name", petNameValue.Text);
                command.Parameters.AddWithValue("@Type", petTypeValue.Text);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Breed", petBreedValue.Text);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Description", descriptionText.Text);
                command.Parameters.AddWithValue("@AgeRange", ageRange);
                command.Parameters.AddWithValue("@Stock", stock);
                command.Parameters.AddWithValue("@HealthStatus", healthStatus);
                command.Parameters.AddWithValue("@PetImg", _petImg ?? (object)DBNull.Value);

                command.ExecuteNonQuery();
                command.Dispose();
                connection.Dispose();

                MessageBox.Show("Pet information updated successfully.");
                recall.LoadItems();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating pet details: {ex.Message}");
            }
        }

        private void addpetImgBtn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                petImg.Image = Image.FromFile(dialog.FileName);
                var ms = new MemoryStream();
                petImg.Image.Save(ms, petImg.Image.RawFormat);
                _petImg = ms.ToArray();
                ms.Dispose();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
