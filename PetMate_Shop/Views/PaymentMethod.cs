using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using PetMate_Shop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetMate_Shop.Views
{
    public partial class PaymentMethod : Form
    {
        string _totalPrice;
        string _customerId;

        public PaymentMethod(string price, string customerId)
        {
            InitializeComponent();
            _totalPrice = price;
            _customerId = customerId;
            PayWithCardRB.Checked = true;
            paymentBtn.Text = $"pay {_totalPrice} BDT";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PayWithCardRB_CheckedChanged(object sender, EventArgs e)
        {
            if (PayWithCardRB.Checked)
            {
                confirmOderBtn.Visible = false;
            }
            else
            {
                confirmOderBtn.Visible = true;
            }
        }

        private void cashOnDelivaryRB_CheckedChanged(object sender, EventArgs e)
        {
            if (PayWithCardRB.Checked)
            {
                confirmOderBtn.Visible = false;
            }
            else
            {
                confirmOderBtn.Visible = true;
            }
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cHNameTB.Text) &&
                !string.IsNullOrWhiteSpace(mmyyTB.Text) &&
                !string.IsNullOrWhiteSpace(cvcTB.Text) &&
                !string.IsNullOrWhiteSpace(cardNumTB.Text))
            {
                string transactionId = Guid.NewGuid().ToString();
                string orderId = IdCreator.GenerateId("CustomerOrder", "CO", 5, 2);
                string paymentId = Guid.NewGuid().ToString();
                string paymentMethod = "Card";
                string paymentStatus = "Completed";

                try
                {
                    var connection = DatabaseConnection.GetConnection();
                    connection.Open();

                    string getActiveCartQuery = "SELECT CartID FROM AddCart WHERE CustomerID = @CustomerID AND CartStatus = 'Active'";
                    string activeCartId = string.Empty;

                    SqlCommand cartCommand = new SqlCommand(getActiveCartQuery, connection);
                    cartCommand.Parameters.AddWithValue("@CustomerID", _customerId);

                    SqlDataReader reader = cartCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        activeCartId = reader["CartID"].ToString();
                    }
                    reader.Close();

                    string insertOrderQuery = @"
                    INSERT INTO CustomerOrder (OrderID, CustomerID, CartID, TotalAmount, OrderStatus, OrderDate)
                    VALUES (@OrderID, @CustomerID, @CartID, @TotalAmount, 'Pending', GETDATE())";

                    SqlCommand orderCommand = new SqlCommand(insertOrderQuery, connection);
                    orderCommand.Parameters.AddWithValue("@OrderID", orderId);
                    orderCommand.Parameters.AddWithValue("@CustomerID", _customerId);
                    orderCommand.Parameters.AddWithValue("@CartID", activeCartId);
                    orderCommand.Parameters.AddWithValue("@TotalAmount", _totalPrice);
                    orderCommand.ExecuteNonQuery();

                    string insertPaymentQuery = @"
                    INSERT INTO Payment (PaymentID, CustomerID, OrderID, Amount, PaymentMethod, TransactionID, PaymentStatus, PaymentDate)
                    VALUES (@PaymentID, @CustomerID, @OrderID, @Amount, @PaymentMethod, @TransactionID, @PaymentStatus, GETDATE())";

                    SqlCommand paymentCommand = new SqlCommand(insertPaymentQuery, connection);
                    paymentCommand.Parameters.AddWithValue("@PaymentID", paymentId);
                    paymentCommand.Parameters.AddWithValue("@CustomerID", _customerId);
                    paymentCommand.Parameters.AddWithValue("@OrderID", orderId);
                    paymentCommand.Parameters.AddWithValue("@Amount", _totalPrice);
                    paymentCommand.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    paymentCommand.Parameters.AddWithValue("@TransactionID", transactionId);
                    paymentCommand.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                    paymentCommand.ExecuteNonQuery();

                    MessageBox.Show($"Payment successful! Transaction ID: {transactionId}");

                    clearAddCard(_customerId);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing payment: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all payment details.");
            }
        }

        private void confirmOderBtn_Click(object sender, EventArgs e)
        {
            Passwordverification passwordverification = new Passwordverification(_customerId);
            passwordverification.ShowDialog();

            if (!passwordverification.IsVerified)
            {
                MessageBox.Show("Order confirmation canceled due to failed password verification.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string orderId = IdCreator.GenerateId("CustomerOrder", "CO", 5, 2);

                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string getActiveCartQuery = "SELECT CartID FROM AddCart WHERE CustomerID = @CustomerID AND CartStatus = 'Active'";
                string activeCartId = string.Empty;

                SqlCommand cartCommand = new SqlCommand(getActiveCartQuery, connection);
                cartCommand.Parameters.AddWithValue("@CustomerID", _customerId);

                SqlDataReader reader = cartCommand.ExecuteReader();
                if (reader.Read())
                {
                    activeCartId = reader["CartID"].ToString();
                }
                reader.Close();

                if (string.IsNullOrEmpty(activeCartId))
                {
                    MessageBox.Show("No active cart found. Cannot confirm order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertOrderQuery = @"
                INSERT INTO CustomerOrder (OrderID, CustomerID, CartID, TotalAmount, OrderStatus, OrderDate)
                VALUES (@OrderID, @CustomerID, @CartID, @TotalAmount, 'Pending', GETDATE())";

                SqlCommand orderCommand = new SqlCommand(insertOrderQuery, connection);
                orderCommand.Parameters.AddWithValue("@OrderID", orderId);
                orderCommand.Parameters.AddWithValue("@CustomerID", _customerId);
                orderCommand.Parameters.AddWithValue("@CartID", activeCartId);
                orderCommand.Parameters.AddWithValue("@TotalAmount", _totalPrice);
                orderCommand.ExecuteNonQuery();

                string paymentId = Guid.NewGuid().ToString();
                string transactionId = Guid.NewGuid().ToString();
                string paymentMethod = "Cash on Delivery";
                string paymentStatus = "Pending";

                string insertPaymentQuery = @"
                INSERT INTO Payment (PaymentID, CustomerID, OrderID, Amount, PaymentMethod, TransactionID, PaymentStatus, PaymentDate)
                VALUES (@PaymentID, @CustomerID, @OrderID, @Amount, @PaymentMethod, @TransactionID, @PaymentStatus, GETDATE())";

                SqlCommand paymentCommand = new SqlCommand(insertPaymentQuery, connection);
                paymentCommand.Parameters.AddWithValue("@PaymentID", paymentId);
                paymentCommand.Parameters.AddWithValue("@CustomerID", _customerId);
                paymentCommand.Parameters.AddWithValue("@OrderID", orderId);
                paymentCommand.Parameters.AddWithValue("@Amount", _totalPrice);
                paymentCommand.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                paymentCommand.Parameters.AddWithValue("@TransactionID", transactionId);
                paymentCommand.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                paymentCommand.ExecuteNonQuery();

                MessageBox.Show("Order confirmed! Payment will be collected on delivery.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAddCard(_customerId);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error confirming order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearAddCard(string customerID)
        {
            string updateQuery = "UPDATE AddCart SET CartStatus = 'Closed' WHERE CustomerID = @CustomerID AND CartStatus = 'Active'";
            string selectQuery = "SELECT UserName FROM Customer WHERE CustomerID = @CustomerID";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                string userName = string.Empty;
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@CustomerID", customerID);

                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    userName = reader["UserName"].ToString();
                }
                reader.Close();

                if (!string.IsNullOrEmpty(userName))
                {
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@CustomerID", customerID);
                    updateCommand.ExecuteNonQuery();

                    MainForm.instance.totalAddcartvalue(userName);
                    AddCartForm.instance.createAddcartCart(userName);
                    AddCartForm.instance.totalPrice(userName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
