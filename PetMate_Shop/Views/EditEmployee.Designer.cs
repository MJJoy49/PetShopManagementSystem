namespace PetMate_Shop.Views
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.formWorkNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTB = new System.Windows.Forms.TextBox();
            this.cityOrAreaNameLabel = new System.Windows.Forms.Label();
            this.cityOrAreaNameTB = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salaryTB = new System.Windows.Forms.TextBox();
            this.RemoveEmployeeBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.EditEmployeeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hireDateValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeIdValue = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
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
            this.formWorkNameLabel.Size = new System.Drawing.Size(277, 44);
            this.formWorkNameLabel.TabIndex = 1;
            this.formWorkNameLabel.Text = "Edit Employee.";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.passwordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordLabel.Location = new System.Drawing.Point(760, 441);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(271, 33);
            this.passwordLabel.TabIndex = 83;
            this.passwordLabel.Text = "Employee Password";
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.passwordTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTB.Location = new System.Drawing.Point(766, 486);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(413, 44);
            this.passwordTB.TabIndex = 82;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.userNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userNameLabel.Location = new System.Drawing.Point(760, 307);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(293, 33);
            this.userNameLabel.TabIndex = 80;
            this.userNameLabel.Text = "Employee User Name";
            // 
            // userNameTB
            // 
            this.userNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.userNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.userNameTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userNameTB.Location = new System.Drawing.Point(766, 352);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.ReadOnly = true;
            this.userNameTB.Size = new System.Drawing.Size(413, 44);
            this.userNameTB.TabIndex = 79;
            this.userNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.phoneNumberLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.phoneNumberLabel.Location = new System.Drawing.Point(86, 470);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(341, 33);
            this.phoneNumberLabel.TabIndex = 77;
            this.phoneNumberLabel.Text = "Employee Phone Number";
            // 
            // phoneNumberTB
            // 
            this.phoneNumberTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.phoneNumberTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumberTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.phoneNumberTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.phoneNumberTB.Location = new System.Drawing.Point(92, 515);
            this.phoneNumberTB.Name = "phoneNumberTB";
            this.phoneNumberTB.Size = new System.Drawing.Size(413, 44);
            this.phoneNumberTB.TabIndex = 76;
            this.phoneNumberTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cityOrAreaNameLabel
            // 
            this.cityOrAreaNameLabel.AutoSize = true;
            this.cityOrAreaNameLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.cityOrAreaNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cityOrAreaNameLabel.Location = new System.Drawing.Point(86, 644);
            this.cityOrAreaNameLabel.Name = "cityOrAreaNameLabel";
            this.cityOrAreaNameLabel.Size = new System.Drawing.Size(356, 33);
            this.cityOrAreaNameLabel.TabIndex = 75;
            this.cityOrAreaNameLabel.Text = "Employee City/Area Name";
            // 
            // cityOrAreaNameTB
            // 
            this.cityOrAreaNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cityOrAreaNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityOrAreaNameTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cityOrAreaNameTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cityOrAreaNameTB.Location = new System.Drawing.Point(92, 689);
            this.cityOrAreaNameTB.Name = "cityOrAreaNameTB";
            this.cityOrAreaNameTB.Size = new System.Drawing.Size(413, 44);
            this.cityOrAreaNameTB.TabIndex = 74;
            this.cityOrAreaNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.emailLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.emailLabel.Location = new System.Drawing.Point(86, 309);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(226, 33);
            this.emailLabel.TabIndex = 72;
            this.emailLabel.Text = "Employee Email";
            // 
            // emailTB
            // 
            this.emailTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.emailTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.emailTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.emailTB.Location = new System.Drawing.Point(92, 354);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(413, 44);
            this.emailTB.TabIndex = 71;
            this.emailTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabel.Location = new System.Drawing.Point(86, 175);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(224, 33);
            this.nameLabel.TabIndex = 70;
            this.nameLabel.Text = "Employee Name";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.nameTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameTB.Location = new System.Drawing.Point(92, 220);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(413, 44);
            this.nameTB.TabIndex = 69;
            this.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.125F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(850, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 33);
            this.label1.TabIndex = 86;
            this.label1.Text = "Employee Salary";
            // 
            // salaryTB
            // 
            this.salaryTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.salaryTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salaryTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.salaryTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.salaryTB.Location = new System.Drawing.Point(766, 619);
            this.salaryTB.Name = "salaryTB";
            this.salaryTB.Size = new System.Drawing.Size(413, 44);
            this.salaryTB.TabIndex = 85;
            this.salaryTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RemoveEmployeeBtn
            // 
            this.RemoveEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.RemoveEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.RemoveEmployeeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.RemoveEmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.RemoveEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveEmployeeBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.RemoveEmployeeBtn.ForeColor = System.Drawing.Color.Green;
            this.RemoveEmployeeBtn.Location = new System.Drawing.Point(1106, 773);
            this.RemoveEmployeeBtn.Name = "RemoveEmployeeBtn";
            this.RemoveEmployeeBtn.Size = new System.Drawing.Size(166, 58);
            this.RemoveEmployeeBtn.TabIndex = 118;
            this.RemoveEmployeeBtn.Text = "Remove";
            this.RemoveEmployeeBtn.UseVisualStyleBackColor = false;
            this.RemoveEmployeeBtn.Click += new System.EventHandler(this.RemoveEmployeeBtn_Click);
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
            this.CancelBtn.Location = new System.Drawing.Point(880, 773);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(166, 58);
            this.CancelBtn.TabIndex = 117;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EditEmployeeBtn
            // 
            this.EditEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.EditEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EditEmployeeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EditEmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.EditEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEmployeeBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.EditEmployeeBtn.ForeColor = System.Drawing.Color.Green;
            this.EditEmployeeBtn.Location = new System.Drawing.Point(643, 773);
            this.EditEmployeeBtn.Name = "EditEmployeeBtn";
            this.EditEmployeeBtn.Size = new System.Drawing.Size(166, 58);
            this.EditEmployeeBtn.TabIndex = 116;
            this.EditEmployeeBtn.Text = "Edit";
            this.EditEmployeeBtn.UseVisualStyleBackColor = false;
            this.EditEmployeeBtn.Click += new System.EventHandler(this.EditEmployeeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.hireDateValue);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.employeeIdValue);
            this.panel2.Controls.Add(this.employeeIDLabel);
            this.panel2.Location = new System.Drawing.Point(765, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 144);
            this.panel2.TabIndex = 119;
            // 
            // hireDateValue
            // 
            this.hireDateValue.AutoSize = true;
            this.hireDateValue.ForeColor = System.Drawing.Color.Gold;
            this.hireDateValue.Location = new System.Drawing.Point(212, 85);
            this.hireDateValue.Name = "hireDateValue";
            this.hireDateValue.Size = new System.Drawing.Size(112, 25);
            this.hireDateValue.TabIndex = 115;
            this.hireDateValue.Text = "E1-001-24";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 114;
            this.label4.Text = "HireDate :";
            // 
            // employeeIdValue
            // 
            this.employeeIdValue.AutoSize = true;
            this.employeeIdValue.ForeColor = System.Drawing.Color.Gold;
            this.employeeIdValue.Location = new System.Drawing.Point(218, 30);
            this.employeeIdValue.Name = "employeeIdValue";
            this.employeeIdValue.Size = new System.Drawing.Size(112, 25);
            this.employeeIdValue.TabIndex = 113;
            this.employeeIdValue.Text = "E1-001-24";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Location = new System.Drawing.Point(61, 30);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(139, 25);
            this.employeeIDLabel.TabIndex = 112;
            this.employeeIDLabel.Text = "EmployeeID :";
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1350, 946);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RemoveEmployeeBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.EditEmployeeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salaryTB);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTB);
            this.Controls.Add(this.cityOrAreaNameLabel);
            this.Controls.Add(this.cityOrAreaNameTB);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEmployee";
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
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTB;
        private System.Windows.Forms.Label cityOrAreaNameLabel;
        private System.Windows.Forms.TextBox cityOrAreaNameTB;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salaryTB;
        private System.Windows.Forms.Button RemoveEmployeeBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button EditEmployeeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label employeeIdValue;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label hireDateValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}