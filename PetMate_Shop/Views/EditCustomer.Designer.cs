namespace PetMate_Shop.Views
{
    partial class EditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.formWorkNameLabel = new System.Windows.Forms.Label();
            this.RemoveCustomerBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.EditCustomerBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalPurchaseValue = new System.Windows.Forms.Label();
            this.totalPetBuyValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerIdValue = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.cityOrAreaNameLabel = new System.Windows.Forms.Label();
            this.cityOrAreaNameTB = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTB = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.formWorkNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 87);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(1289, 19);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(49, 49);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // formWorkNameLabel
            // 
            this.formWorkNameLabel.AutoSize = true;
            this.formWorkNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.formWorkNameLabel.Font = new System.Drawing.Font("Roboto Medium", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formWorkNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.formWorkNameLabel.Location = new System.Drawing.Point(71, 24);
            this.formWorkNameLabel.Name = "formWorkNameLabel";
            this.formWorkNameLabel.Size = new System.Drawing.Size(273, 44);
            this.formWorkNameLabel.TabIndex = 1;
            this.formWorkNameLabel.Text = "Edit Customer.";
            // 
            // RemoveCustomerBtn
            // 
            this.RemoveCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.RemoveCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveCustomerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.RemoveCustomerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.RemoveCustomerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.RemoveCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCustomerBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.RemoveCustomerBtn.ForeColor = System.Drawing.Color.Green;
            this.RemoveCustomerBtn.Location = new System.Drawing.Point(872, 775);
            this.RemoveCustomerBtn.Name = "RemoveCustomerBtn";
            this.RemoveCustomerBtn.Size = new System.Drawing.Size(166, 58);
            this.RemoveCustomerBtn.TabIndex = 131;
            this.RemoveCustomerBtn.Text = "Remove";
            this.RemoveCustomerBtn.UseVisualStyleBackColor = false;
            this.RemoveCustomerBtn.Click += new System.EventHandler(this.RemoveCustomerBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.CancelBtn.ForeColor = System.Drawing.Color.Green;
            this.CancelBtn.Location = new System.Drawing.Point(646, 775);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(166, 58);
            this.CancelBtn.TabIndex = 130;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // EditCustomerBtn
            // 
            this.EditCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.EditCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditCustomerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EditCustomerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EditCustomerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.EditCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCustomerBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.EditCustomerBtn.ForeColor = System.Drawing.Color.Green;
            this.EditCustomerBtn.Location = new System.Drawing.Point(409, 775);
            this.EditCustomerBtn.Name = "EditCustomerBtn";
            this.EditCustomerBtn.Size = new System.Drawing.Size(166, 58);
            this.EditCustomerBtn.TabIndex = 129;
            this.EditCustomerBtn.Text = "Edit";
            this.EditCustomerBtn.UseVisualStyleBackColor = false;
            this.EditCustomerBtn.Click += new System.EventHandler(this.EditCustomerBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.totalPurchaseValue);
            this.panel2.Controls.Add(this.totalPetBuyValue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.customerIdValue);
            this.panel2.Controls.Add(this.employeeIDLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(872, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 144);
            this.panel2.TabIndex = 128;
            // 
            // totalPurchaseValue
            // 
            this.totalPurchaseValue.AutoSize = true;
            this.totalPurchaseValue.ForeColor = System.Drawing.Color.Gold;
            this.totalPurchaseValue.Location = new System.Drawing.Point(206, 96);
            this.totalPurchaseValue.Name = "totalPurchaseValue";
            this.totalPurchaseValue.Size = new System.Drawing.Size(95, 25);
            this.totalPurchaseValue.TabIndex = 134;
            this.totalPurchaseValue.Text = "30000 tk";
            // 
            // totalPetBuyValue
            // 
            this.totalPetBuyValue.AutoSize = true;
            this.totalPetBuyValue.ForeColor = System.Drawing.Color.Gold;
            this.totalPetBuyValue.Location = new System.Drawing.Point(206, 59);
            this.totalPetBuyValue.Name = "totalPetBuyValue";
            this.totalPetBuyValue.Size = new System.Drawing.Size(24, 25);
            this.totalPetBuyValue.TabIndex = 135;
            this.totalPetBuyValue.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 132;
            this.label3.Text = "Total purchase :";
            // 
            // customerIdValue
            // 
            this.customerIdValue.AutoSize = true;
            this.customerIdValue.ForeColor = System.Drawing.Color.Gold;
            this.customerIdValue.Location = new System.Drawing.Point(209, 21);
            this.customerIdValue.Name = "customerIdValue";
            this.customerIdValue.Size = new System.Drawing.Size(112, 25);
            this.customerIdValue.TabIndex = 113;
            this.customerIdValue.Text = "E1-001-24";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Location = new System.Drawing.Point(64, 21);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(136, 25);
            this.employeeIDLabel.TabIndex = 112;
            this.employeeIDLabel.Text = "CustomerID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 133;
            this.label4.Text = "Total pet buy :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.passwordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordLabel.Location = new System.Drawing.Point(857, 525);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(270, 33);
            this.passwordLabel.TabIndex = 127;
            this.passwordLabel.Text = "Customer Password";
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.passwordTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTB.Location = new System.Drawing.Point(863, 570);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(413, 44);
            this.passwordTB.TabIndex = 126;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.userNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userNameLabel.Location = new System.Drawing.Point(857, 391);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(292, 33);
            this.userNameLabel.TabIndex = 125;
            this.userNameLabel.Text = "Customer User Name";
            // 
            // userNameTB
            // 
            this.userNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.userNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userNameTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.userNameTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userNameTB.Location = new System.Drawing.Point(863, 443);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.ReadOnly = true;
            this.userNameTB.Size = new System.Drawing.Size(413, 44);
            this.userNameTB.TabIndex = 124;
            this.userNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cityOrAreaNameLabel
            // 
            this.cityOrAreaNameLabel.AutoSize = true;
            this.cityOrAreaNameLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.cityOrAreaNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cityOrAreaNameLabel.Location = new System.Drawing.Point(84, 537);
            this.cityOrAreaNameLabel.Name = "cityOrAreaNameLabel";
            this.cityOrAreaNameLabel.Size = new System.Drawing.Size(355, 33);
            this.cityOrAreaNameLabel.TabIndex = 123;
            this.cityOrAreaNameLabel.Text = "Customer City/Area Name";
            // 
            // cityOrAreaNameTB
            // 
            this.cityOrAreaNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cityOrAreaNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityOrAreaNameTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cityOrAreaNameTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cityOrAreaNameTB.Location = new System.Drawing.Point(90, 582);
            this.cityOrAreaNameTB.Name = "cityOrAreaNameTB";
            this.cityOrAreaNameTB.Size = new System.Drawing.Size(413, 44);
            this.cityOrAreaNameTB.TabIndex = 122;
            this.cityOrAreaNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.phoneNumberLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.phoneNumberLabel.Location = new System.Drawing.Point(75, 398);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(340, 33);
            this.phoneNumberLabel.TabIndex = 121;
            this.phoneNumberLabel.Text = "Customer Phone Number";
            // 
            // phoneNumberTB
            // 
            this.phoneNumberTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.phoneNumberTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumberTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.phoneNumberTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.phoneNumberTB.Location = new System.Drawing.Point(81, 443);
            this.phoneNumberTB.Name = "phoneNumberTB";
            this.phoneNumberTB.Size = new System.Drawing.Size(413, 44);
            this.phoneNumberTB.TabIndex = 120;
            this.phoneNumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.emailLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.emailLabel.Location = new System.Drawing.Point(75, 248);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(225, 33);
            this.emailLabel.TabIndex = 119;
            this.emailLabel.Text = "Customer Email";
            // 
            // emailTB
            // 
            this.emailTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.emailTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.emailTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.emailTB.Location = new System.Drawing.Point(81, 293);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(413, 44);
            this.emailTB.TabIndex = 118;
            this.emailTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabel.Location = new System.Drawing.Point(75, 114);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(223, 33);
            this.nameLabel.TabIndex = 117;
            this.nameLabel.Text = "Customer Name";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.nameTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameTB.Location = new System.Drawing.Point(81, 159);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(413, 44);
            this.nameTB.TabIndex = 116;
            this.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1350, 946);
            this.Controls.Add(this.RemoveCustomerBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EditCustomerBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.cityOrAreaNameLabel);
            this.Controls.Add(this.cityOrAreaNameTB);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTB);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Label formWorkNameLabel;
        private System.Windows.Forms.Button RemoveCustomerBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button EditCustomerBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.Label cityOrAreaNameLabel;
        private System.Windows.Forms.TextBox cityOrAreaNameTB;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTB;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label customerIdValue;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label totalPurchaseValue;
        private System.Windows.Forms.Label totalPetBuyValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}