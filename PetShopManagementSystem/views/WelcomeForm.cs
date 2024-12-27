using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopManagementSystem.views
{
    public partial class WelcomeForm : Form
    {
        private Point startLocation = new Point(125, 173);
        private Point endLocation = new Point(894, 173);
        private Size startSize = new Size(795, 153);
        private Size endSize = new Size(15, 153);
        private int steps = 120; // Total steps (8 seconds / 50ms interval)
        private int currentStep = 0;
        private float deltaWidth;
        private float deltaX;




        public WelcomeForm()
        {
            InitializeComponent();

            RoundForm.RoundedForm(this, 40, Color.FromArgb(227, 227, 227));

            // Set initial size and location for AnimationPanel
            AnimationPanel.Size = startSize;
            AnimationPanel.Location = startLocation;

            // Calculate step values for size and location
            deltaWidth = (float)(endSize.Width - startSize.Width) / steps;
            deltaX = (float)(endLocation.X - startLocation.X) / steps;
            timer1.Start();
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentStep < steps)
            {
                // Update size and location incrementally
                AnimationPanel.Size = new Size(
                    (int)(startSize.Width + deltaWidth * currentStep),
                    startSize.Height
                );
                AnimationPanel.Location = new Point(
                    (int)(startLocation.X + deltaX * currentStep),
                    startLocation.Y
                );
                currentStep++;
            }
            else
            {
                // Stop the timer when the animation is complete
                timer1.Stop();
                Application.Exit();
            }
        }

       
    }
}
