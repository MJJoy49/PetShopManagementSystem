namespace PetMate_Shop.ComponentForms
{
    partial class PetsListForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetsListForms));
            this.desplayPetPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNewItemPanel = new System.Windows.Forms.Panel();
            this.addNewPetBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sumOfAddFvt = new System.Windows.Forms.Label();
            this.allPetBtn = new System.Windows.Forms.Label();
            this.fvtBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddNewItemPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // desplayPetPanel
            // 
            this.desplayPetPanel.AutoScroll = true;
            this.desplayPetPanel.Location = new System.Drawing.Point(0, 191);
            this.desplayPetPanel.Name = "desplayPetPanel";
            this.desplayPetPanel.Padding = new System.Windows.Forms.Padding(5);
            this.desplayPetPanel.Size = new System.Drawing.Size(1675, 1197);
            this.desplayPetPanel.TabIndex = 0;
            // 
            // AddNewItemPanel
            // 
            this.AddNewItemPanel.Controls.Add(this.addNewPetBtn);
            this.AddNewItemPanel.Controls.Add(this.pictureBox1);
            this.AddNewItemPanel.Location = new System.Drawing.Point(1395, 59);
            this.AddNewItemPanel.Name = "AddNewItemPanel";
            this.AddNewItemPanel.Size = new System.Drawing.Size(260, 72);
            this.AddNewItemPanel.TabIndex = 1;
            // 
            // addNewPetBtn
            // 
            this.addNewPetBtn.AutoSize = true;
            this.addNewPetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addNewPetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addNewPetBtn.Location = new System.Drawing.Point(82, 17);
            this.addNewPetBtn.Name = "addNewPetBtn";
            this.addNewPetBtn.Size = new System.Drawing.Size(162, 32);
            this.addNewPetBtn.TabIndex = 1;
            this.addNewPetBtn.Text = "Add New Pet";
            this.addNewPetBtn.Click += new System.EventHandler(this.addNewPetBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sumOfAddFvt);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.allPetBtn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.fvtBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.searchTB);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1675, 135);
            this.panel2.TabIndex = 2;
            // 
            // sumOfAddFvt
            // 
            this.sumOfAddFvt.AutoSize = true;
            this.sumOfAddFvt.BackColor = System.Drawing.Color.Transparent;
            this.sumOfAddFvt.ForeColor = System.Drawing.Color.Gold;
            this.sumOfAddFvt.Location = new System.Drawing.Point(360, 71);
            this.sumOfAddFvt.Name = "sumOfAddFvt";
            this.sumOfAddFvt.Size = new System.Drawing.Size(24, 25);
            this.sumOfAddFvt.TabIndex = 8;
            this.sumOfAddFvt.Text = "0";
            // 
            // allPetBtn
            // 
            this.allPetBtn.AutoSize = true;
            this.allPetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.allPetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.allPetBtn.Location = new System.Drawing.Point(171, 86);
            this.allPetBtn.Name = "allPetBtn";
            this.allPetBtn.Size = new System.Drawing.Size(55, 32);
            this.allPetBtn.TabIndex = 6;
            this.allPetBtn.Text = "ALL";
            this.allPetBtn.Click += new System.EventHandler(this.allPetBtn_Click);
            // 
            // fvtBtn
            // 
            this.fvtBtn.AutoSize = true;
            this.fvtBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.fvtBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.fvtBtn.Location = new System.Drawing.Point(320, 86);
            this.fvtBtn.Name = "fvtBtn";
            this.fvtBtn.Size = new System.Drawing.Size(56, 32);
            this.fvtBtn.TabIndex = 2;
            this.fvtBtn.Text = "FVT";
            this.fvtBtn.Click += new System.EventHandler(this.fvtBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(830, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search :";
            // 
            // searchTB
            // 
            this.searchTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.searchTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchTB.Location = new System.Drawing.Point(825, 60);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(428, 44);
            this.searchTB.TabIndex = 0;
            this.searchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(1259, 56);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(62, 49);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.searchBtn.TabIndex = 2;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(120, 76);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(269, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // PetsListForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.AddNewItemPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.desplayPetPanel);
            this.Location = new System.Drawing.Point(0, 191);
            this.Name = "PetsListForms";
            this.Size = new System.Drawing.Size(1675, 1388);
            this.Load += new System.EventHandler(this.PetsListForms_Load);
            this.AddNewItemPanel.ResumeLayout(false);
            this.AddNewItemPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel desplayPetPanel;
        private System.Windows.Forms.Panel AddNewItemPanel;
        private System.Windows.Forms.Label addNewPetBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label fvtBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label allPetBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.Label sumOfAddFvt;
    }
}
