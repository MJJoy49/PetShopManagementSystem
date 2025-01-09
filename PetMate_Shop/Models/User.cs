using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMate_Shop.Models
{
    internal abstract class User
    {
        // Properties
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public string QuestionOne { get; set; }
        public string QuestionTwo { get; set; }
        public string QuestionThree { get; set; }
        public string HouseOrBuildingOrFlatNumber { get; set; }
        public string StreetNameOrNumber { get; set; }
        public string CityOrAreaName { get; set; }
        public string PostalCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Static Time Property for Bangladesh Time
        private static DateTime CurrentBangladeshTime => TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Bangladesh Standard Time");

        // Constructor
        public User(string userName, string password, string name, string email, string phone, string role,  string questionOne, string questionTwo, string questionThree, string houseOrBuildingOrFlatNumber, string streetNameOrNumber, string cityOrAreaName, string postalCode)
        {
            UserName = userName;
            Password = password;
            Name = name;
            Email = email;
            Phone = phone;
            Role = role;
            QuestionOne = questionOne;
            QuestionTwo = questionTwo;
            QuestionThree = questionThree;
            HouseOrBuildingOrFlatNumber = houseOrBuildingOrFlatNumber;
            StreetNameOrNumber = streetNameOrNumber;
            CityOrAreaName = cityOrAreaName;
            PostalCode = postalCode;
            CreatedAt = CurrentBangladeshTime;
            UpdatedAt = CurrentBangladeshTime;
        }

        // Convert time to Bangladesh time
        

        // Abstract methods for CRUD operations
        public abstract void CreateUserInDatabase();
    }
}


