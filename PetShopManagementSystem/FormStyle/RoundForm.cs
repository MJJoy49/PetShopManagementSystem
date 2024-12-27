using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundForm
{
    public static void RoundedForm(Form form, int radius, Color borderColor)
    {
        // Create rounded rectangle path
        GraphicsPath path = new GraphicsPath();
        path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
        path.AddArc(new Rectangle(form.Width - radius - 1, 0, radius, radius), 270, 90);
        path.AddArc(new Rectangle(form.Width - radius - 1, form.Height - radius - 1, radius, radius), 0, 90);
        path.AddArc(new Rectangle(0, form.Height - radius - 1, radius, radius), 90, 90);
        path.CloseFigure();

        // Set the form region to the rounded rectangle path
        form.Region = new Region(path);

        // Optional: Draw border
        form.Paint += (sender, e) =>
        {
            using (Pen pen = new Pen(borderColor, 5)) // Adjust color and thickness as needed
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        };
    }
}
