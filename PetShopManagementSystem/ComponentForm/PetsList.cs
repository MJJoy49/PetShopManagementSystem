using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopManagementSystem.ComponentForm;
using System.Windows.Forms;

namespace PetShopManagementSystem.ComponentForm
{
    public partial class PetsList : UserControl
    {
        public static PetsList forFvtCount;
        public PetsList()
        {
            InitializeComponent();
            forFvtCount = this;
            //LoadItems();
        }




        // Dynamically load petCart components
        private void LoadItems()
        {
            //for (int i = 0; i < 24; i++) // Add 5 sample petCart components
            //{
            var petCart = new petCart(); // Assume petCart is a UserContro
            petCart.Dock = DockStyle.Top; // Adjust layout as needed
            petCart.Margin = new Padding(10); // Add spacing between items

            flowLayoutPanel1.Controls.Add(petCart); // Add to flowLayoutPanel1
            //}

        }

        private void addNewPetBtn_Click(object sender, EventArgs e)
        {
            LoadItems();
        }


        public static int fvtCount = 0;
        private void fvtCountLabel_Click(object sender, EventArgs e)
        {
            fvtCount++;
            fvtCountLabel.Text=fvtCount.ToString();
        }
    }
}
