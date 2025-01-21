using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;

namespace PetMate_Shop.Models
{
    internal class Employee : User
    {
        public string EmployeeID { get; set; }
        public float Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string employeeID, string userName, string password, string name, string email, string phone,
                        string role, string questionOneAns, string questionTwoAns, string questionThreeAns,
                        string houseOrBuildingOrFlatNumber, string streetNameOrNumber, string cityOrAreaName,
                        string postalCode, float salary, DateTime hireDate)
            : base(userName, password, name, email, phone, role, questionOneAns, questionTwoAns, questionThreeAns,
                   houseOrBuildingOrFlatNumber, streetNameOrNumber, cityOrAreaName, postalCode)
        {
            EmployeeID = employeeID;
            Salary = salary;
            HireDate = hireDate;
        }

        
        public override void CreateUserInDatabase()
        {
            string usersInsertQuery = "INSERT INTO Users (UserName, Password, Name, Email, Phone, Role, HouseOrBuildingOrFlatNumber, " +
                                      "StreetNameOrNumber, CityOrAreaName, PostalCode, QuestionOneAns, QuestionTwoAns, " +
                                      "QuestionThreeAns, CreatedAt, UpdatedAt) VALUES (@UserName, @Password, @Name, @Email, @Phone, " +
                                      "@Role, @HouseOrBuildingOrFlatNumber, @StreetNameOrNumber, @CityOrAreaName, @PostalCode, " +
                                      "@QuestionOneAns, @QuestionTwoAns, @QuestionThreeAns, @CreatedAt, @UpdatedAt)";

            string employeeInsertQuery = "INSERT INTO Employee (EmployeeID, UserName, Salary, HireDate) VALUES (@EmployeeID, @UserName, @Salary, @HireDate)";

            using (var connection = DatabaseConnection.GetConnection())
            {
                using (var command = new SqlCommand(usersInsertQuery, connection))
                {
                    // Add parameters for Users table
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Role", Role);
                    command.Parameters.AddWithValue("@HouseOrBuildingOrFlatNumber", HouseOrBuildingOrFlatNumber);
                    command.Parameters.AddWithValue("@StreetNameOrNumber", StreetNameOrNumber);
                    command.Parameters.AddWithValue("@CityOrAreaName", CityOrAreaName);
                    command.Parameters.AddWithValue("@PostalCode", PostalCode);
                    command.Parameters.AddWithValue("@QuestionOneAns", QuestionOneAns);
                    command.Parameters.AddWithValue("@QuestionTwoAns", QuestionTwoAns);
                    command.Parameters.AddWithValue("@QuestionThreeAns", QuestionThreeAns);
                    command.Parameters.AddWithValue("@CreatedAt", CreatedAt);
                    command.Parameters.AddWithValue("@UpdatedAt", UpdatedAt);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                
                using (var employeeCommand = new SqlCommand(employeeInsertQuery, connection))
                {
                    employeeCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    employeeCommand.Parameters.AddWithValue("@UserName", UserName);
                    employeeCommand.Parameters.AddWithValue("@Salary", Salary);
                    employeeCommand.Parameters.AddWithValue("@HireDate", HireDate);

                    employeeCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
