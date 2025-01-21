using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetMate_Shop.Models
{
    internal class Customer : User
    {
        public string CustomerID { get; set; }
        private const string role = "Customer";

        public Customer(
            string userName,
            string password,
            string name,
            string email,
            string phone,
            string questionOneAns,
            string questionTwoAns,
            string questionThreeAns,
            string houseOrBuildingOrFlatNumber,
            string streetNameOrNumber,
            string cityOrAreaName,
            string postalCode
        )
        : base(
              userName,
              password,
              name,
              email,
              phone,
              role,
              questionOneAns,
              questionTwoAns,
              questionThreeAns,
              houseOrBuildingOrFlatNumber,
              streetNameOrNumber,
              cityOrAreaName,
              postalCode
        )
        {
            CustomerID = IdCreator.GenerateId("Customer", "C", 4, 2);
            CreateUserInDatabase();
        }

        public override void CreateUserInDatabase()
        {
            string queryUser = "INSERT INTO Users (UserName, Password, Name, Email, Phone, Role, QuestionOneAns, QuestionTwoAns, QuestionThreeAns, HouseOrBuildingOrFlatNumber, StreetNameOrNumber, CityOrAreaName, PostalCode, CreatedAt, UpdatedAt) " +
                               "VALUES (@UserName, @Password, @Name, @Email, @Phone, @Role, @QuestionOneAns, @QuestionTwoAns, @QuestionThreeAns, @HouseOrBuildingOrFlatNumber, @StreetNameOrNumber, @CityOrAreaName, @PostalCode, @CreatedAt, @UpdatedAt)";

            string queryCustomer = "INSERT INTO Customer (CustomerID, UserName) VALUES (@CustomerID, @UserName)";

            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                try
                {
                    // Insert into Users table
                    using (SqlCommand command = new SqlCommand(queryUser, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@QuestionOneAns", QuestionOneAns);
                        command.Parameters.AddWithValue("@QuestionTwoAns", QuestionTwoAns);
                        command.Parameters.AddWithValue("@QuestionThreeAns", QuestionThreeAns);
                        command.Parameters.AddWithValue("@HouseOrBuildingOrFlatNumber", HouseOrBuildingOrFlatNumber);
                        command.Parameters.AddWithValue("@StreetNameOrNumber", StreetNameOrNumber);
                        command.Parameters.AddWithValue("@CityOrAreaName", CityOrAreaName);
                        command.Parameters.AddWithValue("@PostalCode", PostalCode);
                        command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);

                        command.ExecuteNonQuery();
                    }

                    // Insert into Customer table
                    using (SqlCommand command = new SqlCommand(queryCustomer, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@UserName", UserName);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Customer created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
