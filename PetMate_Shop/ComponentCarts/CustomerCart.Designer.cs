namespace PetMate_Shop.ComponentCarts
{
    partial class CustomerCart
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
            this.EditBtn = new System.Windows.Forms.Button();
            this.totalPetBuyValue = new System.Windows.Forms.Label();
            this.totalPurchaseValue = new System.Windows.Forms.Label();
            this.userNameValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerIdValue = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.EditBtn.Location = new System.Drawing.Point(1437, 9);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(117, 39);
            this.EditBtn.TabIndex = 88;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // totalPetBuyValue
            // 
            this.totalPetBuyValue.AutoSize = true;
            this.totalPetBuyValue.ForeColor = System.Drawing.Color.Gold;
            this.totalPetBuyValue.Location = new System.Drawing.Point(970, 16);
            this.totalPetBuyValue.Name = "totalPetBuyValue";
            this.totalPetBuyValue.Size = new System.Drawing.Size(24, 25);
            this.totalPetBuyValue.TabIndex = 87;
            this.totalPetBuyValue.Text = "3";
            // 
            // totalPurchaseValue
            // 
            this.totalPurchaseValue.AutoSize = true;
            this.totalPurchaseValue.ForeColor = System.Drawing.Color.Gold;
            this.totalPurchaseValue.Location = new System.Drawing.Point(1243, 16);
            this.totalPurchaseValue.Name = "totalPurchaseValue";
            this.totalPurchaseValue.Size = new System.Drawing.Size(95, 25);
            this.totalPurchaseValue.TabIndex = 86;
            this.totalPurchaseValue.Text = "30000 tk";
            // 
            // userNameValue
            // 
            this.userNameValue.AutoSize = true;
            this.userNameValue.ForeColor = System.Drawing.Color.Gold;
            this.userNameValue.Location = new System.Drawing.Point(568, 16);
            this.userNameValue.Name = "userNameValue";
            this.userNameValue.Size = new System.Drawing.Size(112, 25);
            this.userNameValue.TabIndex = 85;
            this.userNameValue.Text = "E1-001-24";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(815, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 84;
            this.label4.Text = "Total pet buy :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1070, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 83;
            this.label3.Text = "Total purchase :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "UserName :";
            // 
            // customerIdValue
            // 
            this.customerIdValue.AutoSize = true;
            this.customerIdValue.ForeColor = System.Drawing.Color.Gold;
            this.customerIdValue.Location = new System.Drawing.Point(210, 16);
            this.customerIdValue.Name = "customerIdValue";
            this.customerIdValue.Size = new System.Drawing.Size(112, 25);
            this.customerIdValue.TabIndex = 81;
            this.customerIdValue.Text = "E1-001-24";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Location = new System.Drawing.Point(65, 16);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(136, 25);
            this.employeeIDLabel.TabIndex = 80;
            this.employeeIDLabel.Text = "CustomerID :";
            // 
            // CustomerCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.totalPetBuyValue);
            this.Controls.Add(this.totalPurchaseValue);
            this.Controls.Add(this.userNameValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerIdValue);
            this.Controls.Add(this.employeeIDLabel);
            this.Name = "CustomerCart";
            this.Size = new System.Drawing.Size(1619, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label totalPetBuyValue;
        private System.Windows.Forms.Label totalPurchaseValue;
        private System.Windows.Forms.Label userNameValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label customerIdValue;
        private System.Windows.Forms.Label employeeIDLabel;
    }
}
