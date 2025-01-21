using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using PetMate_Shop.ComponentCarts;
using PetMate_Shop.Database;

namespace PetMate_Shop.ComponentForms
{
    public partial class AdoptionForm : UserControl
    {
        public static AdoptionForm instance;
        string _userName;
        string _role;
        public AdoptionForm(string username, string role)
        {
            _userName = username;
            _role = role;
            InitializeComponent();
            LoadCard();
            instance = this;
        }

        public void LoadCard()
        {
            adopReqCardLayoutPanel.Controls.Clear();

            string query = @"
                                SELECT 
                                A.AdoptionID, A.PetID, A.CustomerID, A.RequestDate, A.Description, 
                                U.Email, U.Phone, U.CityOrAreaName
                            FROM Adoption A
                            INNER JOIN Customer C ON A.CustomerID = C.CustomerID
                            INNER JOIN Users U ON C.UserName = U.UserName
                            WHERE A.AcceptanceStatus = 'not accepted'";

            var connection = DatabaseConnection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string adoptionID = reader["AdoptionID"].ToString();
                    string description = reader["Description"].ToString();
                    string email = reader["Email"].ToString();
                    string phone = reader["Phone"].ToString();
                    string cityAreaName = reader["CityOrAreaName"].ToString();
                    string petId = reader["PetID"].ToString();
                    string customerId = reader["CustomerID"].ToString();
                    string requestDate = Convert.ToDateTime(reader["RequestDate"]).ToString("dd-MM-yyyy");

                    AdopRequstCard adopRequstCard = new AdopRequstCard(adoptionID,
                        description, email, phone, cityAreaName, petId, customerId, requestDate);

                    adopRequstCard.Dock = DockStyle.Top;
                    adopReqCardLayoutPanel.Controls.Add(adopRequstCard);
                }

                reader.Close();
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading adoption requests: " + ex.Message);
            }
        }

        private void allbtn_Click(object sender, EventArgs e)
        {
            LoadCard();
        }
    }
}
