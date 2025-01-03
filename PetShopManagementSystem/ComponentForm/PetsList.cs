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
        public static PetsList? forFvtCount;
        public static int fvtCount = 0;
        public PetsList()
        {
            InitializeComponent();
            forFvtCount = this;
            //LoadItems();
        }


        private void LoadItems()
        {
            var petCart = new petCart();
            petCart.Dock = DockStyle.Top;
            petCart.Margin = new Padding(10);
            flowLayoutPanel1.Controls.Add(petCart);
        }

        private void addNewPetBtn_Click(object sender, EventArgs e)
        {
            LoadItems();
        }


        private void favouriteBtn_Click(object sender, EventArgs e)
        {

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Visible = false;
            }

            // Show only the favorite items (based on fvtCount)
            for (int i = 0; i < fvtCount; i++)
            {
                if (i < flowLayoutPanel1.Controls.Count)
                {
                    flowLayoutPanel1.Controls[i].Visible = true;
                }
                else
                {
                    LoadItems();
                }
            }
        }

        private void allShowPetBtn_Click(object sender, EventArgs e)
        {

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Visible = true;
            }

            for (int i = flowLayoutPanel1.Controls.Count; i < fvtCount; i++)
            {
                LoadItems();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
