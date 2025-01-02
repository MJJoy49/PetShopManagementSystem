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
        public PetsList()
        {
            InitializeComponent();
            LoadItems();
        }

       


        // Dynamically load petCart components
        private void LoadItems()
        {
            for (int i = 0; i < 24; i++) // Add 5 sample petCart components
            {
                var petCart = new petCart(); // Assume petCart is a UserContro
                petCart.Dock = DockStyle.Top; // Adjust layout as needed
                petCart.Margin = new Padding(10); // Add spacing between items

                flowLayoutPanel1.Controls.Add(petCart); // Add to flowLayoutPanel1
            }

        }


        
    }
}
