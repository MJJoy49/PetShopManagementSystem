using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShopManagementSystem.ComponentForm;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PetShopManagementSystem.views
{
    public partial class MainForm : Form
    {
        public static MainForm forAddcartLabel;
        public static int addCartCount = 0;


        public MainForm()
        {
            InitializeComponent();

            addUserControl(userProfileForm);
            RoundPanel.roundedPanel(leftPanel, 40);

            forAddcartLabel = this;


        }




        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimiseBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        //--------------------- Component form Change-----------------------

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            activePanel.Controls.Clear();
            activePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        // Instances of UserControls
        PetsList petsList = new PetsList();
        UsersForm usersForm = new UsersForm();
        NotificationForm notificationForm = new NotificationForm();
        AccessoriesForm accessoriesForm = new AccessoriesForm();
        AdoptionForm adoptionForm = new AdoptionForm();
        AddCartForm addCartForm = new AddCartForm();
        OrdersForms ordersForms = new OrdersForms();
        SettingForm settingForm = new SettingForm();
        TesksForm tasksForm = new TesksForm();
        HelpForm helpForm = new HelpForm();
        UserProfileForm userProfileForm = new UserProfileForm();

        private void petsFromBtn_Click(object sender, EventArgs e)
        {
            addUserControl(petsList);
        }

        private void deshboardFormBtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            addUserControl(dashboard);
        }

        private void usersFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(usersForm);
        }

        private void notificationFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(notificationForm);
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

        private void settingFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(settingForm);
        }

        private void taskFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(tasksForm);
        }

        private void helpFormBtn_Click(object sender, EventArgs e)
        {
            addUserControl(helpForm);
        }

        private void userProfileBtn_Click(object sender, EventArgs e)
        {
            addUserControl(userProfileForm);
        }

        //---------------------------------------------------------------

        private void countAddCart_Click(object sender, EventArgs e)
        {

        }

        private void countAddCart_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}






