using PetMate_Shop.Database;
using PetMate_Shop.Models;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class AddPet : Form
    {
        float _petPriceValue;
        int _petAvailableValue;
        string _petNameValue;
        string _petTypeValue;
        string _petBreedValue;
        string _petGenderValue;
        string _petAgeRangeValue;
        string _petHealthStatus;
        string _descriptionText;
        byte[] _petImg;

        public AddPet()
        {
            InitializeComponent();
        }

        private void addPetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _petPriceValue = float.Parse(petPriceValue.Text.Trim());
                _petAvailableValue = int.Parse(petAvailableValue.Text.Trim());
                _petNameValue = petNameValue.Text.Trim();
                _petTypeValue = petTypeValue.Text.Trim();
                _petBreedValue = petBreedValue.Text.Trim();
                _petGenderValue = maleR.Checked ? maleR.Text : femaleR.Text;
                _petAgeRangeValue = puppyR.Checked ? puppyR.Text : kittenR.Checked ? kittenR.Text : adultR.Text;
                _petHealthStatus = fullyVR.Checked ? fullyVR.Text : partialyVR.Checked ? partialyVR.Text : noVR.Text;
                _descriptionText = descriptionText.Text.Trim();

                if (_petImg == null)
                {
                    MessageBox.Show("Please upload a pet image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                InsertPetData();
                MessageBox.Show("Pet added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addpetImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select a Pet Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                _petImg = ConvertImageToByteArray(imagePath);

                petImg.Image = Image.FromFile(imagePath);
            }
        }

        private byte[] ConvertImageToByteArray(string imagePath)
        {
            return File.ReadAllBytes(imagePath);
        }

        private void InsertPetData()
        {
            var connection = DatabaseConnection.GetConnection();
            string query = @"INSERT INTO Pet 
                            (PetID, Name, Type, Gender, Breed, Price, Description, AgeRange, Stock, HealthStatus, PetImg)
                            VALUES 
                            (@PetID, @Name, @Type, @Gender, @Breed, @Price, @Description, @AgeRange, @Stock, @HealthStatus, @PetImg)";

            var command = new SqlCommand(query, connection);
            string petID = IdCreator.GenerateId("Pet", "P", 3, 2);

            command.Parameters.AddWithValue("@PetID", petID);
            command.Parameters.AddWithValue("@Name", _petNameValue);
            command.Parameters.AddWithValue("@Type", _petTypeValue);
            command.Parameters.AddWithValue("@Gender", _petGenderValue);
            command.Parameters.AddWithValue("@Breed", _petBreedValue);
            command.Parameters.AddWithValue("@Price", _petPriceValue);
            command.Parameters.AddWithValue("@Description", _descriptionText);
            command.Parameters.AddWithValue("@AgeRange", _petAgeRangeValue);
            command.Parameters.AddWithValue("@Stock", _petAvailableValue);
            command.Parameters.AddWithValue("@HealthStatus", _petHealthStatus);
            command.Parameters.AddWithValue("@PetImg", _petImg);

            connection.Open();
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Dispose();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
