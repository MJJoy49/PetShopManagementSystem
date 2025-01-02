namespace PetShopManagementSystem.views
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            AnimationPanel = new Panel();
            GifPicBox = new PictureBox();
            welcomeLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            AnimationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GifPicBox).BeginInit();
            SuspendLayout();
            // 
            // AnimationPanel
            // 
            AnimationPanel.BackColor = Color.Transparent;
            AnimationPanel.Controls.Add(GifPicBox);
            AnimationPanel.Location = new Point(125, 173);
            AnimationPanel.Name = "AnimationPanel";
            AnimationPanel.Size = new Size(795, 183);
            AnimationPanel.TabIndex = 7;
            // 
            // GifPicBox
            // 
            GifPicBox.BackColor = Color.Transparent;
            GifPicBox.Image = (Image)resources.GetObject("GifPicBox.Image");
            GifPicBox.Location = new Point(0, 5);
            GifPicBox.Margin = new Padding(0);
            GifPicBox.Name = "GifPicBox";
            GifPicBox.Size = new Size(215, 178);
            GifPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            GifPicBox.TabIndex = 3;
            GifPicBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Franklin Gothic Heavy", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.WhiteSmoke;
            welcomeLabel.Location = new Point(220, 266);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(612, 66);
            welcomeLabel.TabIndex = 6;
            welcomeLabel.Text = "WELCOME TO PET SHOP";
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1060, 546);
            Controls.Add(AnimationPanel);
            Controls.Add(welcomeLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeForm";
            AnimationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GifPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel AnimationPanel;
        private PictureBox GifPicBox;
        private Label welcomeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}