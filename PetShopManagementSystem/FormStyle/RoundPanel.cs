using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundPanel
{
    public static void roundedPanel(Panel panel, int radius)
    {
        // Create rounded rectangle path
        GraphicsPath path = new GraphicsPath();
        path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top-left corner
        path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90); // Top-right corner
        path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90); // Bottom-right corner
        path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90); // Bottom-left corner
        path.CloseFigure();

        // Set the panel's region to the rounded rectangle path
        panel.Region = new Region(path);

        // Optional: Draw a border for the panel
        panel.Paint += (sender, e) =>
        {
            Pen pen = new Pen(Color.Black, 2); // Border color and thickness
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, path);
        };
    }
}
