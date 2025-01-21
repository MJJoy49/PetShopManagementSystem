namespace PetMate_Shop.ComponentCarts
{
    partial class EmployeeCard
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
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.employeeIdValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userNameValue = new System.Windows.Forms.Label();
            this.salaryValue = new System.Windows.Forms.Label();
            this.hireDateValue = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Location = new System.Drawing.Point(70, 16);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(139, 25);
            this.employeeIDLabel.TabIndex = 0;
            this.employeeIDLabel.Text = "EmployeeID :";
            // 
            // employeeIdValue
            // 
            this.employeeIdValue.AutoSize = true;
            this.employeeIdValue.ForeColor = System.Drawing.Color.Gold;
            this.employeeIdValue.Location = new System.Drawing.Point(215, 16);
            this.employeeIdValue.Name = "employeeIdValue";
            this.employeeIdValue.Size = new System.Drawing.Size(112, 25);
            this.employeeIdValue.TabIndex = 1;
            this.employeeIdValue.Text = "E1-001-24";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(799, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salary :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1113, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "HireDate :";
            // 
            // userNameValue
            // 
            this.userNameValue.AutoSize = true;
            this.userNameValue.ForeColor = System.Drawing.Color.Gold;
            this.userNameValue.Location = new System.Drawing.Point(573, 16);
            this.userNameValue.Name = "userNameValue";
            this.userNameValue.Size = new System.Drawing.Size(112, 25);
            this.userNameValue.TabIndex = 5;
            this.userNameValue.Text = "E1-001-24";
            // 
            // salaryValue
            // 
            this.salaryValue.AutoSize = true;
            this.salaryValue.ForeColor = System.Drawing.Color.Gold;
            this.salaryValue.Location = new System.Drawing.Point(890, 16);
            this.salaryValue.Name = "salaryValue";
            this.salaryValue.Size = new System.Drawing.Size(112, 25);
            this.salaryValue.TabIndex = 6;
            this.salaryValue.Text = "E1-001-24";
            // 
            // hireDateValue
            // 
            this.hireDateValue.AutoSize = true;
            this.hireDateValue.ForeColor = System.Drawing.Color.Gold;
            this.hireDateValue.Location = new System.Drawing.Point(1236, 16);
            this.hireDateValue.Name = "hireDateValue";
            this.hireDateValue.Size = new System.Drawing.Size(112, 25);
            this.hireDateValue.TabIndex = 7;
            this.hireDateValue.Text = "E1-001-24";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.EditBtn.FlatAppearance.BorderSize = 2;
            this.EditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Century", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.Gold;
            this.EditBtn.Location = new System.Drawing.Point(1442, 9);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(117, 39);
            this.EditBtn.TabIndex = 79;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // EmployeeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.hireDateValue);
            this.Controls.Add(this.salaryValue);
            this.Controls.Add(this.userNameValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeIdValue);
            this.Controls.Add(this.employeeIDLabel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EmployeeCard";
            this.Size = new System.Drawing.Size(1619, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label employeeIdValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userNameValue;
        private System.Windows.Forms.Label salaryValue;
        private System.Windows.Forms.Label hireDateValue;
        private System.Windows.Forms.Button EditBtn;
    }
}
