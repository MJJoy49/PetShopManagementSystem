using PetMate_Shop.ComponentForms;
using PetMate_Shop.Database;
using PetMate_Shop.FormStyle;
using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using PetMate_Shop.ComponentCarts;
using PetMate_Shop.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetMate_Shop.Views
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public string _userName { set; get; }
        public string _role { set; get; }
        private UserProfileForm userProfileForm;
        private PetsListForms petsListForms;
        private NotificationForm notificationForm;
        private AccessoriesForm accessoriesForm;
        private AdoptionForm adoptionForm;
        private AddCartForm addCartForm;
        private OrdersForms ordersForms;
        private HelpForm helpForm;
        private DashboardForm dashboard;
        private UsersForm usersForm;

        public MainForm(string userName)
        {
            _userName = userName;
            getRole(userName);
            InitializeComponent();
            RoundPanel.roundedPanel(manuPanel, 40);
            userProfileBtn.Text = _userName;

            InitializeUserControls();
            addUserControl(userProfileForm);
            totalAddcartvalue(userName);
            unseenNotificationCount(userName);
            instance = this;

        }

        private void getRole(string userName)
        {
            string query = @"
                            SELECT Role
                            FROM Users
                            WHERE UserName = @UserName";

            try
            {
                var connection = DatabaseConnection.GetConnection();
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    _role = reader["Role"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void InitializeUserControls()
        {
            userProfileForm = new UserProfileForm(this._userName, this._role);
            petsListForms = new PetsListForms(this._userName, this._role);
            notificationForm = new NotificationForm(this._userName, this._role);
            accessoriesForm = new AccessoriesForm(this._userName, this._role);
            adoptionForm = new AdoptionForm(this._userName, this._role);
            addCartForm = new AddCartForm(this._userName, this._role);
            ordersForms = new OrdersForms(this._userName, this._role);
            helpForm = new HelpForm(this._userName, this._role);
            dashboard = new DashboardForm();
            usersForm = new UsersForm(this._userName, this._role);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            activePanel.Controls.Clear();
            activePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void petsFromBtn_Click(object sender, EventArgs e)
        {
            addUserControl(petsListForms);
        }

        private void deshboardFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(dashboard);
        }

        private void usersFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(usersForm);
        }

        int notificationContorl = 0;
        private void notificationFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(notificationForm);
            if (notificationContorl == 1)
            {
                NotificationForm.instance.markNotificationsAsSeen(_userName);
            }
            notificationContorl = 1;
        }

        private void accessoriesFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(accessoriesForm);
        }

        private void adoptionFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(adoptionForm);
        }

        private void addCartFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(addCartForm);
        }

        private void orderFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(ordersForms);
        }

        private void helpFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(helpForm);
        }

        private void userProfileBtn_Click(object sender, EventArgs e)
        {
            addUserControl(userProfileForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_role == "Customer")
            {
                petPanel.Location = new Point(3, 315);
                petPanel.Visible = true;

                accessoriesPanel.Location = new Point(3, 421);
                accessoriesPanel.Visible = true;

                notificationPanel.Location = new Point(3, 533);
                notificationPanel.Visible = true;

                addCartPanel.Location = new Point(3, 638);
                addCartPanel.Visible = true;

                adoptionPanel.Location = new Point(3, 751);
                adoptionPanel.Visible = true;

                helpPanal.Location = new Point(3, 857);
                helpPanal.Visible = true;
            }

            else if (_role == "Employee")
            {
                petPanel.Location = new Point(3, 315);
                petPanel.Visible = true;

                accessoriesPanel.Location = new Point(3, 421);
                accessoriesPanel.Visible = true;

                userPanel.Location = new Point(3, 533);
                userPanel.Visible = true;

                ordersPanel.Location = new Point(3, 638);
                ordersPanel.Visible = true;
            }

            else if (_role == "Volunteer")
            {
                notificationPanel.Location = new Point(3, 533);
                notificationPanel.Visible = true;

                helpPanal.Location = new Point(3, 638);
                helpPanal.Visible = true;
            }
            else
            {
                dashboardPanel.Location = new Point(3, 315);
                dashboardPanel.Visible = true;

                petPanel.Location = new Point(3, 421);
                petPanel.Visible = true;

                accessoriesPanel.Location = new Point(3, 533);
                accessoriesPanel.Visible = true;

                userPanel.Location = new Point(3, 638);
                userPanel.Visible = true;

                ordersPanel.Location = new Point(3, 751);
                ordersPanel.Visible = true;
            }
        }

        public void totalAddcartvalue(string userName)
        {
            string checkRoleQuery = @"SELECT COUNT(*) 
                              FROM Users 
                              WHERE UserName = @UserName AND Role = 'Customer';";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();

            SqlCommand roleCommand = new SqlCommand(checkRoleQuery, connection);
            roleCommand.Parameters.AddWithValue("@UserName", userName);

            int isCustomer = (int)roleCommand.ExecuteScalar();

            if (isCustomer == 0)
            {
                return;
            }

            string query = @"SELECT COUNT(*) AS TotalAddCart
                             FROM AddCart
                             WHERE CustomerID = (
                                 SELECT CustomerID
                                 FROM Customer
                                 WHERE UserName = @UserName
                             ) AND CartStatus = 'Active';";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", userName);

            int totalAddCart = (int)command.ExecuteScalar();

            totalAddcart.Text = totalAddCart.ToString();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logOutLogoBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void unseenNotificationCount(string userName)
        {
            string checkRoleQuery = @"SELECT COUNT(*) 
                      FROM Users 
                      WHERE UserName = @UserName AND Role = 'Customer';";

            var connection = DatabaseConnection.GetConnection();
            connection.Open();

            SqlCommand roleCommand = new SqlCommand(checkRoleQuery, connection);
            roleCommand.Parameters.AddWithValue("@UserName", userName);

            int isCustomer = (int)roleCommand.ExecuteScalar();

            if (isCustomer == 0)
            {
                return;
            }

            string query = @"SELECT COUNT(*) AS UnseenNotificationCount
                     FROM Notification
                     WHERE UserName = @UserName AND Status = 'unseen';";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", userName);

            int unseenCount = (int)command.ExecuteScalar();

            if (unseenCount > 0)
            {
                notificationCountLabel.Text = unseenCount.ToString();
            }
            else
            {
                notificationCountLabel.Text = "0";
            }
        }

        private void minimiseBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
