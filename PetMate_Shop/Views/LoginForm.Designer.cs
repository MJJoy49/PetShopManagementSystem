namespace PetMate_Shop.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.loginStyleLabel = new System.Windows.Forms.Label();
            this.applicationLogo = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.userNameLogo = new System.Windows.Forms.PictureBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLogo = new System.Windows.Forms.PictureBox();
            this.forgetPasswordBtn = new System.Windows.Forms.Label();
            this.showPasswordBtn = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Controls.Add(this.SignUpBtn);
            this.leftPanel.Controls.Add(this.loginStyleLabel);
            this.leftPanel.Controls.Add(this.applicationLogo);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(413, 1002);
            this.leftPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 89);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 16.125F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(53, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 52);
            this.label5.TabIndex = 0;
            this.label5.Text = "PetMate Shop.";
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.SignUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.SignUpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.SignUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.SignUpBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SignUpBtn.Location = new System.Drawing.Point(103, 851);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(215, 70);
            this.SignUpBtn.TabIndex = 2;
            this.SignUpBtn.Text = "Sign up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // loginStyleLabel
            // 
            this.loginStyleLabel.AutoSize = true;
            this.loginStyleLabel.Font = new System.Drawing.Font("Times New Roman", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.loginStyleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.loginStyleLabel.Location = new System.Drawing.Point(126, 489);
            this.loginStyleLabel.Name = "loginStyleLabel";
            this.loginStyleLabel.Size = new System.Drawing.Size(182, 49);
            this.loginStyleLabel.TabIndex = 1;
            this.loginStyleLabel.Text = "Login →";
            // 
            // applicationLogo
            // 
            this.applicationLogo.Image = ((System.Drawing.Image)(resources.GetObject("applicationLogo.Image")));
            this.applicationLogo.Location = new System.Drawing.Point(64, 335);
            this.applicationLogo.Name = "applicationLogo";
            this.applicationLogo.Size = new System.Drawing.Size(287, 225);
            this.applicationLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.applicationLogo.TabIndex = 0;
            this.applicationLogo.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(1502, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(49, 49);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.Green;
            this.loginBtn.Location = new System.Drawing.Point(793, 761);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(166, 58);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.clearBtn.ForeColor = System.Drawing.Color.Red;
            this.clearBtn.Location = new System.Drawing.Point(1053, 761);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(166, 58);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // userNameLogo
            // 
            this.userNameLogo.Image = ((System.Drawing.Image)(resources.GetObject("userNameLogo.Image")));
            this.userNameLogo.Location = new System.Drawing.Point(741, 315);
            this.userNameLogo.Name = "userNameLogo";
            this.userNameLogo.Size = new System.Drawing.Size(45, 39);
            this.userNameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userNameLogo.TabIndex = 5;
            this.userNameLogo.TabStop = false;
            // 
            // userNameTB
            // 
            this.userNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.userNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.userNameTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userNameTB.Location = new System.Drawing.Point(806, 310);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(413, 44);
            this.userNameTB.TabIndex = 6;
            this.userNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.userNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userNameLabel.Location = new System.Drawing.Point(800, 263);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(159, 33);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.passwordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordLabel.Location = new System.Drawing.Point(800, 470);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(137, 33);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.passwordTB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTB.Location = new System.Drawing.Point(806, 515);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(413, 44);
            this.passwordTB.TabIndex = 9;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // passwordLogo
            // 
            this.passwordLogo.Image = ((System.Drawing.Image)(resources.GetObject("passwordLogo.Image")));
            this.passwordLogo.Location = new System.Drawing.Point(741, 520);
            this.passwordLogo.Name = "passwordLogo";
            this.passwordLogo.Size = new System.Drawing.Size(45, 39);
            this.passwordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.passwordLogo.TabIndex = 8;
            this.passwordLogo.TabStop = false;
            // 
            // forgetPasswordBtn
            // 
            this.forgetPasswordBtn.AutoSize = true;
            this.forgetPasswordBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.forgetPasswordBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.forgetPasswordBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.forgetPasswordBtn.Location = new System.Drawing.Point(812, 610);
            this.forgetPasswordBtn.Name = "forgetPasswordBtn";
            this.forgetPasswordBtn.Size = new System.Drawing.Size(187, 32);
            this.forgetPasswordBtn.TabIndex = 11;
            this.forgetPasswordBtn.Text = "Forget Password";
            this.forgetPasswordBtn.Click += new System.EventHandler(this.forgetPasswordBtn_Click);
            // 
            // showPasswordBtn
            // 
            this.showPasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordBtn.Image = ((System.Drawing.Image)(resources.GetObject("showPasswordBtn.Image")));
            this.showPasswordBtn.Location = new System.Drawing.Point(1174, 576);
            this.showPasswordBtn.Name = "showPasswordBtn";
            this.showPasswordBtn.Size = new System.Drawing.Size(45, 39);
            this.showPasswordBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showPasswordBtn.TabIndex = 12;
            this.showPasswordBtn.TabStop = false;
            this.showPasswordBtn.Click += new System.EventHandler(this.showPasswordBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1562, 1002);
            this.Controls.Add(this.showPasswordBtn);
            this.Controls.Add(this.forgetPasswordBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.passwordLogo);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.userNameLogo);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Label loginStyleLabel;
        private System.Windows.Forms.PictureBox applicationLogo;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.PictureBox userNameLogo;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.PictureBox passwordLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label forgetPasswordBtn;
        private System.Windows.Forms.PictureBox showPasswordBtn;
    }
}