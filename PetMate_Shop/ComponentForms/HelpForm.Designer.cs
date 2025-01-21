namespace PetMate_Shop.ComponentForms
{
    partial class HelpForm
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
            this.VolunteerflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.acceptHelp = new System.Windows.Forms.Label();
            this.allVolunteerBtn = new System.Windows.Forms.Label();
            this.myRequest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VolunteerflowLayoutPanel
            // 
            this.VolunteerflowLayoutPanel.AutoScroll = true;
            this.VolunteerflowLayoutPanel.Location = new System.Drawing.Point(33, 113);
            this.VolunteerflowLayoutPanel.Name = "VolunteerflowLayoutPanel";
            this.VolunteerflowLayoutPanel.Size = new System.Drawing.Size(1601, 1246);
            this.VolunteerflowLayoutPanel.TabIndex = 0;
            // 
            // acceptHelp
            // 
            this.acceptHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptHelp.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.acceptHelp.Location = new System.Drawing.Point(291, 63);
            this.acceptHelp.Name = "acceptHelp";
            this.acceptHelp.Size = new System.Drawing.Size(200, 37);
            this.acceptHelp.TabIndex = 1;
            this.acceptHelp.Text = "Accept Help";
            this.acceptHelp.Visible = false;
            this.acceptHelp.Click += new System.EventHandler(this.acceptHelp_Click);
            // 
            // allVolunteerBtn
            // 
            this.allVolunteerBtn.AutoSize = true;
            this.allVolunteerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allVolunteerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allVolunteerBtn.Location = new System.Drawing.Point(66, 63);
            this.allVolunteerBtn.Name = "allVolunteerBtn";
            this.allVolunteerBtn.Size = new System.Drawing.Size(180, 37);
            this.allVolunteerBtn.TabIndex = 2;
            this.allVolunteerBtn.Text = "Volunteers";
            this.allVolunteerBtn.Click += new System.EventHandler(this.allVolunteerBtn_Click);
            // 
            // myRequest
            // 
            this.myRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myRequest.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.myRequest.Location = new System.Drawing.Point(517, 63);
            this.myRequest.Name = "myRequest";
            this.myRequest.Size = new System.Drawing.Size(200, 37);
            this.myRequest.TabIndex = 3;
            this.myRequest.Text = "My Request";
            this.myRequest.Visible = false;
            this.myRequest.Click += new System.EventHandler(this.myRequest_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.myRequest);
            this.Controls.Add(this.allVolunteerBtn);
            this.Controls.Add(this.acceptHelp);
            this.Controls.Add(this.VolunteerflowLayoutPanel);
            this.Name = "HelpForm";
            this.Size = new System.Drawing.Size(1675, 1388);
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel VolunteerflowLayoutPanel;
        private System.Windows.Forms.Label acceptHelp;
        private System.Windows.Forms.Label allVolunteerBtn;
        private System.Windows.Forms.Label myRequest;
    }
}
