using PetShopManagementSystem.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopManagementSystem.ComponentForm
{
    public partial class AddCartForm : UserControl
    {
        public AddCartForm()
        {
            InitializeComponent();
        }


        int updateCartCount;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm.addCartCount--;
            updateCartCount = MainForm.addCartCount;
            string addCartNumber = updateCartCount.ToString();
            MainForm.forAddcartLabel.countAddCart.Text = addCartNumber;
        }
    }
}
