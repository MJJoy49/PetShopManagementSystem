using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundForm
{
    public static void roundedForm(Form form, int radius)
    {
        // Create rounded rectangle path
        GraphicsPath path = new GraphicsPath();
        path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
        path.AddArc(new Rectangle(form.Width - radius, 0, radius, radius), 270, 90);
        path.AddArc(new Rectangle(form.Width - radius, form.Height - radius, radius, radius), 0, 90);
        path.AddArc(new Rectangle(0, form.Height - radius, radius, radius), 90, 90);
        path.CloseFigure();

        // Set the form region to the rounded rectangle path
        form.Region = new Region(path);

        // Optional: Draw border
        form.Paint += (sender, e) =>
        {
            Pen pen = new Pen(Color.Black, 3); // Adjust color and thickness as needed
            e.Graphics.DrawPath(pen, path);
        };
    }
}
