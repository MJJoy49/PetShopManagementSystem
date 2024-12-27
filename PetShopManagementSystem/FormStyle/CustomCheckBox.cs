using System;
using System.Drawing;
using System.Windows.Forms;

namespace messManager.FormStyle
{
    internal class CustomCheckBox : Control
    {
        public static void customCheckBox(CheckBox cb, string borderColor, string tickColor, int radius)
        {
            // Parse the colors from the strings
            Color border = ColorTranslator.FromHtml(borderColor); // Convert hex color string to Color
            Color tick = ColorTranslator.FromHtml(tickColor);

            // Set the appearance of the checkbox
            cb.FlatStyle = FlatStyle.Flat;
            cb.FlatAppearance.BorderSize = 0; // Remove default border size
            cb.Appearance = Appearance.Button;

            // Set a circular size for the checkbox based on radius
            cb.Size = new Size(radius * 2, radius * 2); // Make sure the checkbox is always circular (width = height)
            cb.TextAlign = ContentAlignment.MiddleLeft; // Text will align left (after the checkbox)
            cb.Padding = new Padding(radius + 5, 0, 0, 0); // Add gap between checkbox and text

            // Add an event handler to draw the custom checkmark
            cb.Paint += (sender, e) =>
            {
                // Draw the border (circle)
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillEllipse(new SolidBrush(border), 0, 0, cb.Width, cb.Height); // Draw the circular border

                // Draw the tick if the checkbox is checked
                if (cb.Checked)
                {
                    using (Pen tickPen = new Pen(tick, 3)) // Adjust the tick size and color
                    {
                        // Adjust the tick mark position and size
                        int tickSize = radius / 3;
                        e.Graphics.DrawLine(tickPen, cb.Width / 4, cb.Height / 2, cb.Width / 2, cb.Height - tickSize);
                        e.Graphics.DrawLine(tickPen, cb.Width / 2, cb.Height - tickSize, cb.Width - tickSize, cb.Height / 4);
                    }
                }
            };
        }
    }
}
