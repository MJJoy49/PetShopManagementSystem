using PetMate_Shop.Database;
using PetMate_Shop.Models;
using System;
using System.Data.SqlClient;

namespace PetMate_Shop.Models
{
    internal class Volunteer : User
    {
        public string VolunteerID { get; private set; }
        public int TasksCompleted { get; set; }
        public int RewardPoints { get; set; }

        public Volunteer(
            string volunteerId,
            string userName,
            string password,
            string name,
            string email,
            string phone,
            string houseOrBuildingOrFlatNumber,
            string streetNameOrNumber,
            string cityOrAreaName,
            string postalCode,
            string questionOneAns,
            string questionTwoAns,
            string questionThreeAns
        ) : base(userName, password, name, email, phone, "Volunteer", questionOneAns, questionTwoAns, questionThreeAns, houseOrBuildingOrFlatNumber, streetNameOrNumber, cityOrAreaName, postalCode)
        {
            VolunteerID = volunteerId;
            TasksCompleted = 0;
            RewardPoints = 0;
        }

        public override void CreateUserInDatabase()
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                try
                {
                    
                    string userInsertQuery = @"INSERT INTO Users 
                        (UserName, Password, Name, Email, Phone, Role, HouseOrBuildingOrFlatNumber, StreetNameOrNumber, CityOrAreaName, PostalCode, QuestionOneAns, QuestionTwoAns, QuestionThreeAns, CreatedAt, UpdatedAt) 
                        VALUES 
                        (@UserName, @Password, @Name, @Email, @Phone, @Role, @HouseOrBuildingOrFlatNumber, @StreetNameOrNumber, @CityOrAreaName, @PostalCode, @QuestionOneAns, @QuestionTwoAns, @QuestionThreeAns, @CreatedAt, @UpdatedAt)";

                    using (var userCommand = new SqlCommand(userInsertQuery, connection))
                    {
                        userCommand.Parameters.AddWithValue("@UserName", UserName);
                        userCommand.Parameters.AddWithValue("@Password", Password);
                        userCommand.Parameters.AddWithValue("@Name", Name);
                        userCommand.Parameters.AddWithValue("@Email", Email);
                        userCommand.Parameters.AddWithValue("@Phone", Phone);
                        userCommand.Parameters.AddWithValue("@Role", Role);
                        userCommand.Parameters.AddWithValue("@HouseOrBuildingOrFlatNumber", HouseOrBuildingOrFlatNumber);
                        userCommand.Parameters.AddWithValue("@StreetNameOrNumber", StreetNameOrNumber);
                        userCommand.Parameters.AddWithValue("@CityOrAreaName", CityOrAreaName);
                        userCommand.Parameters.AddWithValue("@PostalCode", PostalCode);
                        userCommand.Parameters.AddWithValue("@QuestionOneAns", QuestionOneAns);
                        userCommand.Parameters.AddWithValue("@QuestionTwoAns", QuestionTwoAns);
                        userCommand.Parameters.AddWithValue("@QuestionThreeAns", QuestionThreeAns);
                        userCommand.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                        userCommand.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);

                        userCommand.ExecuteNonQuery();
                    }

                    
                    string volunteerInsertQuery = @"INSERT INTO Volunteer 
                        (VolunteerID, UserName, TasksCompleted, RewardPoints) 
                        VALUES 
                        (@VolunteerID, @UserName, @TasksCompleted, @RewardPoints)";

                    using (var volunteerCommand = new SqlCommand(volunteerInsertQuery, connection))
                    {
                        volunteerCommand.Parameters.AddWithValue("@VolunteerID", VolunteerID);
                        volunteerCommand.Parameters.AddWithValue("@UserName", UserName);
                        volunteerCommand.Parameters.AddWithValue("@TasksCompleted", TasksCompleted);
                        volunteerCommand.Parameters.AddWithValue("@RewardPoints", RewardPoints);

                        volunteerCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while adding the volunteer: " + ex.Message);
                }
            }
        }
    }
}
