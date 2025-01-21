namespace PetMate_Shop.ComponentForms
{
    partial class AdoptionForm
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
            this.adopReqCardLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // adopReqCardLayoutPanel
            // 
            this.adopReqCardLayoutPanel.Location = new System.Drawing.Point(35, 106);
            this.adopReqCardLayoutPanel.Name = "adopReqCardLayoutPanel";
            this.adopReqCardLayoutPanel.Size = new System.Drawing.Size(1613, 1248);
            this.adopReqCardLayoutPanel.TabIndex = 3;
            // 
            // AdoptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.adopReqCardLayoutPanel);
            this.Name = "AdoptionForm";
            this.Size = new System.Drawing.Size(1675, 1388);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel adopReqCardLayoutPanel;
    }
}
