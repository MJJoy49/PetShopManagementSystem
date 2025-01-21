namespace PetMate_Shop.Views
{
    partial class HelpRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpRequest));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.volunteerIdValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formWorkNameLabel = new System.Windows.Forms.Label();
            this.cancelOrderBtn = new System.Windows.Forms.Button();
            this.sendRequestBtn = new System.Windows.Forms.Button();
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.petIdTB = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.volunteerIdValue);
            this.panel5.Location = new System.Drawing.Point(78, 124);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 66);
            this.panel5.TabIndex = 133;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(29, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Volunteer Id :";
            // 
            // volunteerIdValue
            // 
            this.volunteerIdValue.AutoSize = true;
            this.volunteerIdValue.ForeColor = System.Drawing.Color.Gold;
            this.volunteerIdValue.Location = new System.Drawing.Point(174, 20);
            this.volunteerIdValue.Name = "volunteerIdValue";
            this.volunteerIdValue.Size = new System.Drawing.Size(113, 25);
            this.volunteerIdValue.TabIndex = 29;
            this.volunteerIdValue.Text = "D1-001-24";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.formWorkNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 84);
            this.panel1.TabIndex = 132;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(931, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(56, 50);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // formWorkNameLabel
            // 
            this.formWorkNameLabel.AutoSize = true;
            this.formWorkNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.formWorkNameLabel.Font = new System.Drawing.Font("Roboto Medium", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formWorkNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.formWorkNameLabel.Location = new System.Drawing.Point(91, 20);
            this.formWorkNameLabel.Name = "formWorkNameLabel";
            this.formWorkNameLabel.Size = new System.Drawing.Size(263, 44);
            this.formWorkNameLabel.TabIndex = 2;
            this.formWorkNameLabel.Text = "Help Request.";
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cancelOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelOrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cancelOrderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cancelOrderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cancelOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelOrderBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.cancelOrderBtn.ForeColor = System.Drawing.Color.Green;
            this.cancelOrderBtn.Location = new System.Drawing.Point(239, 617);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Size = new System.Drawing.Size(166, 58);
            this.cancelOrderBtn.TabIndex = 139;
            this.cancelOrderBtn.Text = "Cancel";
            this.cancelOrderBtn.UseVisualStyleBackColor = false;
            this.cancelOrderBtn.Click += new System.EventHandler(this.cancelOrderBtn_Click);
            // 
            // sendRequestBtn
            // 
            this.sendRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.sendRequestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendRequestBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sendRequestBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sendRequestBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.sendRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendRequestBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.sendRequestBtn.ForeColor = System.Drawing.Color.Green;
            this.sendRequestBtn.Location = new System.Drawing.Point(474, 616);
            this.sendRequestBtn.Name = "sendRequestBtn";
            this.sendRequestBtn.Size = new System.Drawing.Size(257, 58);
            this.sendRequestBtn.TabIndex = 138;
            this.sendRequestBtn.Text = "Send Request";
            this.sendRequestBtn.UseVisualStyleBackColor = false;
            this.sendRequestBtn.Click += new System.EventHandler(this.sendRequestBtn_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.descriptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionText.Font = new System.Drawing.Font("Times New Roman", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionText.ForeColor = System.Drawing.SystemColors.Info;
            this.descriptionText.Location = new System.Drawing.Point(78, 271);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(830, 318);
            this.descriptionText.TabIndex = 137;
            this.descriptionText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.125F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(375, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 33);
            this.label6.TabIndex = 136;
            this.label6.Text = "Help Description";
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.petNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.petNameLabel.Location = new System.Drawing.Point(543, 101);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(98, 33);
            this.petNameLabel.TabIndex = 141;
            this.petNameLabel.Text = "Pet ID";
            // 
            // petIdTB
            // 
            this.petIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.petIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petIdTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.petIdTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.petIdTB.Location = new System.Drawing.Point(540, 146);
            this.petIdTB.Name = "petIdTB";
            this.petIdTB.Size = new System.Drawing.Size(413, 44);
            this.petIdTB.TabIndex = 140;
            this.petIdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HelpRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1015, 721);
            this.Controls.Add(this.petNameLabel);
            this.Controls.Add(this.petIdTB);
            this.Controls.Add(this.cancelOrderBtn);
            this.Controls.Add(this.sendRequestBtn);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpRequest";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label volunteerIdValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label formWorkNameLabel;
        private System.Windows.Forms.Button cancelOrderBtn;
        private System.Windows.Forms.Button sendRequestBtn;
        private System.Windows.Forms.RichTextBox descriptionText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.TextBox petIdTB;
    }
}