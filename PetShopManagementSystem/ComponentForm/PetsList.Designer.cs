namespace PetShopManagementSystem.ComponentForm
{
    partial class PetsList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel6 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 191);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(25);
            flowLayoutPanel1.Size = new Size(1675, 1197);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel1);
            panel6.Controls.Add(radioButton2);
            panel6.Controls.Add(radioButton3);
            panel6.Controls.Add(radioButton1);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(textBox1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1675, 135);
            panel6.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(1395, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 72);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(82, 17);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 1;
            label2.Text = "Add New Pet";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.add_30;
            pictureBox2.Location = new Point(19, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.FromArgb(236, 236, 236);
            radioButton2.Location = new Point(1135, 18);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(158, 36);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Categories";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.FromArgb(236, 236, 236);
            radioButton3.Location = new Point(1022, 17);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(109, 36);
            radioButton3.TabIndex = 5;
            radioButton3.Text = "Name";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.ForeColor = Color.FromArgb(236, 236, 236);
            radioButton1.Location = new Point(951, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 36);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Id";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(139, 139, 139);
            label1.Location = new Point(817, 17);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 2;
            label1.Text = "Search by :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search_40;
            pictureBox1.Location = new Point(1258, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(33, 33, 33);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(139, 139, 139);
            textBox1.Location = new Point(825, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(428, 44);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // PetsList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(panel6);
            Controls.Add(flowLayoutPanel1);
            Name = "PetsList";
            Size = new Size(1675, 1388);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel6;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}
