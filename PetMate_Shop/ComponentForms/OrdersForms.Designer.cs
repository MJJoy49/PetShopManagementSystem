namespace PetMate_Shop.ComponentForms
{
    partial class OrdersForms
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
            this.odersLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // odersLayoutPanel
            // 
            this.odersLayoutPanel.AutoScroll = true;
            this.odersLayoutPanel.Location = new System.Drawing.Point(30, 56);
            this.odersLayoutPanel.Name = "odersLayoutPanel";
            this.odersLayoutPanel.Size = new System.Drawing.Size(1620, 1287);
            this.odersLayoutPanel.TabIndex = 0;
            // 
            // OrdersForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.odersLayoutPanel);
            this.Name = "OrdersForms";
            this.Size = new System.Drawing.Size(1675, 1388);
            this.Load += new System.EventHandler(this.OrdersForms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel odersLayoutPanel;
    }
}
