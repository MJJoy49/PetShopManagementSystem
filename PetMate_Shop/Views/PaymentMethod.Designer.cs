namespace PetMate_Shop.Views
{
    partial class PaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMethod));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PayWithCardRB = new System.Windows.Forms.RadioButton();
            this.cashOnDelivaryRB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmOderBtn = new System.Windows.Forms.Button();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cHNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cvcTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mmyyTB = new System.Windows.Forms.TextBox();
            this.cardNumTB = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(280, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // PayWithCardRB
            // 
            this.PayWithCardRB.AutoSize = true;
            this.PayWithCardRB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PayWithCardRB.Location = new System.Drawing.Point(50, 45);
            this.PayWithCardRB.Name = "PayWithCardRB";
            this.PayWithCardRB.Size = new System.Drawing.Size(172, 29);
            this.PayWithCardRB.TabIndex = 2;
            this.PayWithCardRB.TabStop = true;
            this.PayWithCardRB.Text = "Pay with card";
            this.PayWithCardRB.UseVisualStyleBackColor = true;
            this.PayWithCardRB.CheckedChanged += new System.EventHandler(this.PayWithCardRB_CheckedChanged);
            // 
            // cashOnDelivaryRB
            // 
            this.cashOnDelivaryRB.AutoSize = true;
            this.cashOnDelivaryRB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashOnDelivaryRB.Location = new System.Drawing.Point(256, 45);
            this.cashOnDelivaryRB.Name = "cashOnDelivaryRB";
            this.cashOnDelivaryRB.Size = new System.Drawing.Size(204, 29);
            this.cashOnDelivaryRB.TabIndex = 3;
            this.cashOnDelivaryRB.TabStop = true;
            this.cashOnDelivaryRB.Text = "Cash on delivary";
            this.cashOnDelivaryRB.UseVisualStyleBackColor = true;
            this.cashOnDelivaryRB.CheckedChanged += new System.EventHandler(this.cashOnDelivaryRB_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.confirmOderBtn);
            this.panel1.Controls.Add(this.paymentBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cHNameTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cvcTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mmyyTB);
            this.panel1.Controls.Add(this.cardNumTB);
            this.panel1.Location = new System.Drawing.Point(50, 169);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(788, 518);
            this.panel1.TabIndex = 4;
            // 
            // confirmOderBtn
            // 
            this.confirmOderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmOderBtn.Location = new System.Drawing.Point(453, 439);
            this.confirmOderBtn.Name = "confirmOderBtn";
            this.confirmOderBtn.Size = new System.Drawing.Size(305, 59);
            this.confirmOderBtn.TabIndex = 9;
            this.confirmOderBtn.Text = "Confirm order";
            this.confirmOderBtn.UseVisualStyleBackColor = true;
            this.confirmOderBtn.Click += new System.EventHandler(this.confirmOderBtn_Click);
            // 
            // paymentBtn
            // 
            this.paymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBtn.Location = new System.Drawing.Point(50, 439);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(375, 59);
            this.paymentBtn.TabIndex = 8;
            this.paymentBtn.Text = "Pay 1000 BDT";
            this.paymentBtn.UseVisualStyleBackColor = true;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(24, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Card Holder Name";
            // 
            // cHNameTB
            // 
            this.cHNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(25)))));
            this.cHNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cHNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.cHNameTB.Location = new System.Drawing.Point(23, 350);
            this.cHNameTB.Name = "cHNameTB";
            this.cHNameTB.Size = new System.Drawing.Size(499, 56);
            this.cHNameTB.TabIndex = 6;
            this.cHNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(440, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "CVC/CVV";
            // 
            // cvcTB
            // 
            this.cvcTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(25)))));
            this.cvcTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvcTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.cvcTB.Location = new System.Drawing.Point(439, 197);
            this.cvcTB.Name = "cvcTB";
            this.cvcTB.Size = new System.Drawing.Size(267, 56);
            this.cvcTB.TabIndex = 4;
            this.cvcTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(24, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "MM/YY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your Card Number";
            // 
            // mmyyTB
            // 
            this.mmyyTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(25)))));
            this.mmyyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmyyTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.mmyyTB.Location = new System.Drawing.Point(23, 197);
            this.mmyyTB.Name = "mmyyTB";
            this.mmyyTB.Size = new System.Drawing.Size(267, 56);
            this.mmyyTB.TabIndex = 1;
            this.mmyyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardNumTB
            // 
            this.cardNumTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(25)))));
            this.cardNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNumTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.cardNumTB.Location = new System.Drawing.Point(23, 66);
            this.cardNumTB.Name = "cardNumTB";
            this.cardNumTB.Size = new System.Drawing.Size(499, 56);
            this.cardNumTB.TabIndex = 0;
            this.cardNumTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(840, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(911, 730);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cashOnDelivaryRB);
            this.Controls.Add(this.PayWithCardRB);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentMethod";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton PayWithCardRB;
        private System.Windows.Forms.RadioButton cashOnDelivaryRB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cardNumTB;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox mmyyTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cHNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cvcTB;
        private System.Windows.Forms.Button confirmOderBtn;
    }
}