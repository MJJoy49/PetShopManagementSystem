namespace PetMate_Shop.ComponentForms
{
    partial class AddCartForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalPriceValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCartDataFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderConfirmBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.totalPriceValue);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(122, 1024);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1438, 82);
            this.panel2.TabIndex = 129;
            // 
            // totalPriceValue
            // 
            this.totalPriceValue.AutoSize = true;
            this.totalPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceValue.ForeColor = System.Drawing.Color.Gold;
            this.totalPriceValue.Location = new System.Drawing.Point(1202, 22);
            this.totalPriceValue.Name = "totalPriceValue";
            this.totalPriceValue.Size = new System.Drawing.Size(121, 37);
            this.totalPriceValue.TabIndex = 1;
            this.totalPriceValue.Text = "0.00 tk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(995, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Price :";
            // 
            // AddCartDataFlowLayout
            // 
            this.AddCartDataFlowLayout.AutoScroll = true;
            this.AddCartDataFlowLayout.BackColor = System.Drawing.Color.Transparent;
            this.AddCartDataFlowLayout.Location = new System.Drawing.Point(25, 49);
            this.AddCartDataFlowLayout.Name = "AddCartDataFlowLayout";
            this.AddCartDataFlowLayout.Padding = new System.Windows.Forms.Padding(5);
            this.AddCartDataFlowLayout.Size = new System.Drawing.Size(1623, 894);
            this.AddCartDataFlowLayout.TabIndex = 130;
            // 
            // OrderConfirmBtn
            // 
            this.OrderConfirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.OrderConfirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderConfirmBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.OrderConfirmBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.OrderConfirmBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.OrderConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderConfirmBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.OrderConfirmBtn.ForeColor = System.Drawing.Color.Green;
            this.OrderConfirmBtn.Location = new System.Drawing.Point(1198, 1144);
            this.OrderConfirmBtn.Name = "OrderConfirmBtn";
            this.OrderConfirmBtn.Size = new System.Drawing.Size(257, 58);
            this.OrderConfirmBtn.TabIndex = 131;
            this.OrderConfirmBtn.Text = "Order confirm";
            this.OrderConfirmBtn.UseVisualStyleBackColor = false;
            this.OrderConfirmBtn.Click += new System.EventHandler(this.OrderConfirmBtn_Click);
            // 
            // AddCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.OrderConfirmBtn);
            this.Controls.Add(this.AddCartDataFlowLayout);
            this.Controls.Add(this.panel2);
            this.Name = "AddCartForm";
            this.Size = new System.Drawing.Size(1675, 1388);
            this.Load += new System.EventHandler(this.AddCartForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel AddCartDataFlowLayout;
        private System.Windows.Forms.Button OrderConfirmBtn;
        private System.Windows.Forms.Label totalPriceValue;
        private System.Windows.Forms.Label label1;
    }
}
