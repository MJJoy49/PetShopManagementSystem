using PetMate_Shop.Database;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public static class DatabaseHelper
{
    public static void UpdateItemStock(string tableName, string itemId, int quantity)
    {
        if (tableName != "Pet" && tableName != "Accessories")
        {
            throw new ArgumentException("Invalid table name.");
        }

        try
        {
            var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = $@"
            UPDATE {tableName}
            SET Stock = Stock + @Quantity
            WHERE {(tableName == "Pet" ? "PetID" : "AccessoryID")} = @ItemID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@ItemID", itemId);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 0)
            {
                MessageBox.Show($"No rows updated. Check if {itemId} exists in {tableName}.");
            }
            else
            {
                MessageBox.Show($"Successfully updated stock for {itemId} in {tableName}.");
            }

            command.Dispose();
            connection.Dispose();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}");
        }
    }

    public static void ReduceItemStock(string tableName, string itemId, int quantity)
    {
        if (tableName != "Pet" && tableName != "Accessories")
        {
            throw new ArgumentException("Invalid table name.");
        }

        try
        {
            var connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = $@"
            UPDATE {tableName}
            SET Stock = Stock - @Quantity
            WHERE {(tableName == "Pet" ? "PetID" : "AccessoryID")} = @ItemID
            AND Stock >= @Quantity"; 

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@ItemID", itemId);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 0)
            {
                MessageBox.Show($"No rows updated. Check if {itemId} exists in {tableName} or if the stock is sufficient.");
            }
            else
            {
                MessageBox.Show($"Successfully reduced stock for {itemId} in {tableName}.");
            }

            command.Dispose();
            connection.Dispose();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}");
        }
    }




    public static string GetCustomerUsername(string customerId)
    {
        string username = null;
        var connection = DatabaseConnection.GetConnection();
        SqlCommand command = new SqlCommand($"SELECT UserName FROM Customer WHERE CustomerID = @CustomerID", connection);

        command.Parameters.AddWithValue("@CustomerID", customerId);
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            username = reader["UserName"].ToString();
        }
        reader.Close();
        connection.Close();

        return username;
    }

    public static string GetVolunteerUsername(string volunteerId)
    {
        string username = null;
        var connection = DatabaseConnection.GetConnection();
        SqlCommand command = new SqlCommand($"SELECT UserName FROM Volunteer WHERE VolunteerID = @VolunteerID", connection);

        command.Parameters.AddWithValue("@VolunteerID", volunteerId);
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            username = reader["UserName"].ToString();
        }
        reader.Close();
        connection.Close();

        return username;
    }
}
