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

namespace PetShopManagementSystem.ComponentForm
{
    public partial class petCart : UserControl
    {
        public petCart()
        {
            InitializeComponent();
            RoundedCorners(this, 30);
        }

        public petCart(IContainer components, PictureBox pictureBox1, Label petName)
        {
            this.components = components;
            this.pictureBox1 = pictureBox1;
            this.petName = petName;
        }



        private void RoundedCorners(Control control, int radius)
        {
            // Create rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top-left corner
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90); // Top-right corner
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90); // Bottom-right corner
            path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the control's region to the rounded rectangle
            control.Region = new Region(path);
        }


        int addFvt =0;
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            if (addFvt == 0)
            {
                addFvt = 1;
                pictureBox2.Image = Properties.Resources.star_30;
            }
            

            else
            {
                addFvt = 0;
                pictureBox2.Image = Properties.Resources.add_favorite_30;
            }
        }

    }
}
