using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMate_Shop.Models
{
    internal abstract class User
    {
        
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public string QuestionOneAns { get; set; }
        public string QuestionTwoAns { get; set; }
        public string QuestionThreeAns { get; set; }
        public string HouseOrBuildingOrFlatNumber { get; set; }
        public string StreetNameOrNumber { get; set; }
        public string CityOrAreaName { get; set; }
        public string PostalCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        private static DateTime GetCurrentBangladeshTime()
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Bangladesh Standard Time");
        }



        public User(string userName, string password, string name, string email, string phone, string role,  string questionOneAns, string questionTwoAns, string questionThreeAns, string houseOrBuildingOrFlatNumber, string streetNameOrNumber, string cityOrAreaName, string postalCode)
        {
            UserName = userName;
            Password = password;
            Name = name;
            Email = email;
            Phone = phone;
            Role = role;
            QuestionOneAns = questionOneAns;
            QuestionTwoAns = questionTwoAns;
            QuestionThreeAns = questionThreeAns;
            HouseOrBuildingOrFlatNumber = houseOrBuildingOrFlatNumber;
            StreetNameOrNumber = streetNameOrNumber;
            CityOrAreaName = cityOrAreaName;
            PostalCode = postalCode;
            CreatedAt = GetCurrentBangladeshTime();
            UpdatedAt = GetCurrentBangladeshTime();
        }

        public abstract void CreateUserInDatabase();
    }
}


