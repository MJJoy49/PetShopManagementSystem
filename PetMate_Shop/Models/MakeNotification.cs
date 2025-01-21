using System;
using System.Data.SqlClient;
using PetMate_Shop.Database;

namespace PetMate_Shop.Models
{
    internal class MakeNotification
    {
        public static void AddNotification(string userName, string message)
        {
            
            string notificationId = IdCreator.GenerateId("Notification", "N", 4, 2);

            
            string status = "unseen";
            DateTime sentDate = DateTime.Now;

           
            string query = @"
                INSERT INTO Notification (NotificationID, UserName, Message, Status, SentDate)
                VALUES (@NotificationID, @UserName, @Message, @Status, @SentDate)";

            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@NotificationID", notificationId);
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Message", message);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@SentDate", sentDate);

                        
                        command.ExecuteNonQuery();
                    }
                }

                
                Console.WriteLine("Notification added successfully!");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
