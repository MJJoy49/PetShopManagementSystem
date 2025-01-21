namespace PetMate_Shop.ComponentForms
{
    partial class NotificationForm
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
            this.NoticationflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // NoticationflowLayoutPanel
            // 
            this.NoticationflowLayoutPanel.Location = new System.Drawing.Point(30, 65);
            this.NoticationflowLayoutPanel.Name = "NoticationflowLayoutPanel";
            this.NoticationflowLayoutPanel.Size = new System.Drawing.Size(1608, 1299);
            this.NoticationflowLayoutPanel.TabIndex = 0;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.NoticationflowLayoutPanel);
            this.Name = "NotificationForm";
            this.Size = new System.Drawing.Size(1675, 1388);
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel NoticationflowLayoutPanel;
    }
}
