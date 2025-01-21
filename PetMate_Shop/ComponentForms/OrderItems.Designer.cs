namespace PetMate_Shop.ComponentForms
{
    partial class OrderItems
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemIdValueLabel = new System.Windows.Forms.Label();
            this.quantityValueLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item ID:";
            // 
            // itemIdValueLabel
            // 
            this.itemIdValueLabel.AutoSize = true;
            this.itemIdValueLabel.ForeColor = System.Drawing.Color.Gold;
            this.itemIdValueLabel.Location = new System.Drawing.Point(98, 13);
            this.itemIdValueLabel.Name = "itemIdValueLabel";
            this.itemIdValueLabel.Size = new System.Drawing.Size(132, 25);
            this.itemIdValueLabel.TabIndex = 1;
            this.itemIdValueLabel.Text = "2237277227";
            // 
            // quantityValueLabel
            // 
            this.quantityValueLabel.AutoSize = true;
            this.quantityValueLabel.ForeColor = System.Drawing.Color.Gold;
            this.quantityValueLabel.Location = new System.Drawing.Point(372, 13);
            this.quantityValueLabel.Name = "quantityValueLabel";
            this.quantityValueLabel.Size = new System.Drawing.Size(48, 25);
            this.quantityValueLabel.TabIndex = 3;
            this.quantityValueLabel.Text = "223";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(268, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity:";
            // 
            // OrderItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.quantityValueLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemIdValueLabel);
            this.Controls.Add(this.label1);
            this.Name = "OrderItems";
            this.Size = new System.Drawing.Size(446, 52);
            this.Load += new System.EventHandler(this.OrderItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label itemIdValueLabel;
        private System.Windows.Forms.Label quantityValueLabel;
        private System.Windows.Forms.Label label4;
    }
}
