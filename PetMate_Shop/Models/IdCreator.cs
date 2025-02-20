﻿using PetMate_Shop.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PetMate_Shop.Models
{
    internal class IdCreator
    {
        public static string GenerateId(string tableName, string prefix, int numericDigits, int yearDigits)
        {
            string currentYear = DateTime.Now.Year.ToString().Substring(2, yearDigits);
            string lastId = GetLastIdFromDatabase(tableName);
            string newId;


            if (!string.IsNullOrEmpty(lastId))
            {
                string[] parts = lastId.Split('-');
                string currentPrefix = parts[0];
                int currentSequence = int.Parse(parts[1]);
                string lastYear = parts[2];

                if (lastYear == currentYear)
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                    currentPrefix = IncrementPrefix(currentPrefix);
                }

                newId = $"{currentPrefix}-{currentSequence.ToString($"D{numericDigits}")}-{currentYear}";
            }
            else
            {
                newId = $"{prefix}1-{new string('0', numericDigits - 1)}1-{currentYear}";
            }

            return newId;
        }

        private static string IncrementPrefix(string prefix)
        {
            char letter = prefix[0];
            int number = int.Parse(prefix.Substring(1));

            if (number < 9)
            {
                number++;
            }
            else
            {
                letter++;
                number = 1;
            }

            return $"{letter}{number}";
        }

        private static string GetLastIdFromDatabase(string tableName)
        {
            
            var idColumnMapping = new Dictionary<string, string>
            {
                { "Admin", "AdminID" },
                { "Customer", "CustomerID" },
                { "Employee", "EmployeeID" },
                { "Pet", "PetID" },
                { "Accessories", "AccessoryID" },
                { "AddCart", "CartID" },
                { "CustomerOrder", "OrderID" },
                { "Payment", "PaymentID" },
                { "Adoption", "AdoptionID" },
                { "Volunteer", "VolunteerID" },
                { "HelpRequest", "HelpRequestID" },
                { "Notification", "NotificationID" },
                { "BuyPet", "BuyPetID" }
             };

            
            if (!idColumnMapping.ContainsKey(tableName))
            {
                throw new ArgumentException($"Invalid table name: {tableName}");
            }

            string idColumn = idColumnMapping[tableName];
            string query = $"SELECT TOP 1 {idColumn} FROM {tableName} ORDER BY {idColumn} DESC";

            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }

    }
}
