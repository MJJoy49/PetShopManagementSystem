namespace PetMate_Shop.ComponentCarts
{
    partial class BuyPetID
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
            this.puschaseValueLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.petIdValueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adoptionRequestBtn = new System.Windows.Forms.Button();
            this.adoptedValueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // puschaseValueLabel
            // 
            this.puschaseValueLabel.AutoSize = true;
            this.puschaseValueLabel.ForeColor = System.Drawing.Color.Gold;
            this.puschaseValueLabel.Location = new System.Drawing.Point(466, 26);
            this.puschaseValueLabel.Name = "puschaseValueLabel";
            this.puschaseValueLabel.Size = new System.Drawing.Size(48, 25);
            this.puschaseValueLabel.TabIndex = 7;
            this.puschaseValueLabel.Text = "223";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(293, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puschase Date :";
            // 
            // petIdValueLabel
            // 
            this.petIdValueLabel.AutoSize = true;
            this.petIdValueLabel.ForeColor = System.Drawing.Color.Gold;
            this.petIdValueLabel.Location = new System.Drawing.Point(113, 26);
            this.petIdValueLabel.Name = "petIdValueLabel";
            this.petIdValueLabel.Size = new System.Drawing.Size(132, 25);
            this.petIdValueLabel.TabIndex = 5;
            this.petIdValueLabel.Text = "2237277227";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pet ID:";
            // 
            // adoptionRequestBtn
            // 
            this.adoptionRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.adoptionRequestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adoptionRequestBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.adoptionRequestBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.adoptionRequestBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.adoptionRequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adoptionRequestBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.adoptionRequestBtn.ForeColor = System.Drawing.Color.Green;
            this.adoptionRequestBtn.Location = new System.Drawing.Point(964, 9);
            this.adoptionRequestBtn.Name = "adoptionRequestBtn";
            this.adoptionRequestBtn.Size = new System.Drawing.Size(403, 58);
            this.adoptionRequestBtn.TabIndex = 37;
            this.adoptionRequestBtn.Text = "Adoption Request";
            this.adoptionRequestBtn.UseVisualStyleBackColor = false;
            this.adoptionRequestBtn.Click += new System.EventHandler(this.adoptionRequestBtn_Click);
            // 
            // adoptedValueLabel
            // 
            this.adoptedValueLabel.AutoSize = true;
            this.adoptedValueLabel.ForeColor = System.Drawing.Color.Gold;
            this.adoptedValueLabel.Location = new System.Drawing.Point(763, 26);
            this.adoptedValueLabel.Name = "adoptedValueLabel";
            this.adoptedValueLabel.Size = new System.Drawing.Size(137, 25);
            this.adoptedValueLabel.TabIndex = 39;
            this.adoptedValueLabel.Text = "C2-00023-25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(622, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Adopted By :";
            // 
            // BuyPetID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.adoptedValueLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adoptionRequestBtn);
            this.Controls.Add(this.puschaseValueLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.petIdValueLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BuyPetID";
            this.Size = new System.Drawing.Size(1414, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label puschaseValueLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label petIdValueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adoptionRequestBtn;
        private System.Windows.Forms.Label adoptedValueLabel;
        private System.Windows.Forms.Label label3;
    }
}
