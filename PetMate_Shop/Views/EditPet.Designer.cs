﻿namespace PetMate_Shop.Views
{
    partial class EditPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formWorkNameLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fullyVR = new System.Windows.Forms.RadioButton();
            this.partialyVR = new System.Windows.Forms.RadioButton();
            this.noVR = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adultR = new System.Windows.Forms.RadioButton();
            this.puppyR = new System.Windows.Forms.RadioButton();
            this.kittenR = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.femaleR = new System.Windows.Forms.RadioButton();
            this.maleR = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.petAvailableValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.petPriceValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editPetBtn = new System.Windows.Forms.Button();
            this.descriptionText = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.petBreedValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.petTypeValue = new System.Windows.Forms.TextBox();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.petNameValue = new System.Windows.Forms.TextBox();
            this.addpetImgBtn = new System.Windows.Forms.Button();
            this.petImg = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.petIdValue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petImg)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.formWorkNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 84);
            this.panel1.TabIndex = 2;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(1272, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(56, 50);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // formWorkNameLabel
            // 
            this.formWorkNameLabel.AutoSize = true;
            this.formWorkNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.formWorkNameLabel.Font = new System.Drawing.Font("Roboto Medium", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formWorkNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.formWorkNameLabel.Location = new System.Drawing.Point(80, 21);
            this.formWorkNameLabel.Name = "formWorkNameLabel";
            this.formWorkNameLabel.Size = new System.Drawing.Size(166, 44);
            this.formWorkNameLabel.TabIndex = 2;
            this.formWorkNameLabel.Text = "Edit Pet.";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fullyVR);
            this.panel4.Controls.Add(this.partialyVR);
            this.panel4.Controls.Add(this.noVR);
            this.panel4.Location = new System.Drawing.Point(501, 947);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(786, 80);
            this.panel4.TabIndex = 115;
            // 
            // fullyVR
            // 
            this.fullyVR.AutoSize = true;
            this.fullyVR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullyVR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fullyVR.Location = new System.Drawing.Point(52, 13);
            this.fullyVR.Name = "fullyVR";
            this.fullyVR.Size = new System.Drawing.Size(219, 33);
            this.fullyVR.TabIndex = 81;
            this.fullyVR.Text = "Fully Vaccinated";
            this.fullyVR.UseVisualStyleBackColor = true;
            // 
            // partialyVR
            // 
            this.partialyVR.AutoSize = true;
            this.partialyVR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partialyVR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.partialyVR.Location = new System.Drawing.Point(277, 13);
            this.partialyVR.Name = "partialyVR";
            this.partialyVR.Size = new System.Drawing.Size(253, 33);
            this.partialyVR.TabIndex = 82;
            this.partialyVR.Text = "Partially Vaccinated";
            this.partialyVR.UseVisualStyleBackColor = true;
            // 
            // noVR
            // 
            this.noVR.AutoSize = true;
            this.noVR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noVR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.noVR.Location = new System.Drawing.Point(536, 13);
            this.noVR.Name = "noVR";
            this.noVR.Size = new System.Drawing.Size(200, 33);
            this.noVR.TabIndex = 83;
            this.noVR.Text = "No Vaccinated";
            this.noVR.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adultR);
            this.panel3.Controls.Add(this.puppyR);
            this.panel3.Controls.Add(this.kittenR);
            this.panel3.Location = new System.Drawing.Point(655, 824);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 68);
            this.panel3.TabIndex = 114;
            // 
            // adultR
            // 
            this.adultR.AutoSize = true;
            this.adultR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.adultR.Location = new System.Drawing.Point(342, 12);
            this.adultR.Name = "adultR";
            this.adultR.Size = new System.Drawing.Size(98, 33);
            this.adultR.TabIndex = 87;
            this.adultR.Text = "Adult";
            this.adultR.UseVisualStyleBackColor = true;
            // 
            // puppyR
            // 
            this.puppyR.AutoSize = true;
            this.puppyR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puppyR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.puppyR.Location = new System.Drawing.Point(49, 12);
            this.puppyR.Name = "puppyR";
            this.puppyR.Size = new System.Drawing.Size(112, 33);
            this.puppyR.TabIndex = 85;
            this.puppyR.Text = "Puppy";
            this.puppyR.UseVisualStyleBackColor = true;
            // 
            // kittenR
            // 
            this.kittenR.AutoSize = true;
            this.kittenR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kittenR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kittenR.Location = new System.Drawing.Point(202, 12);
            this.kittenR.Name = "kittenR";
            this.kittenR.Size = new System.Drawing.Size(105, 33);
            this.kittenR.TabIndex = 86;
            this.kittenR.Text = "Kitten";
            this.kittenR.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.femaleR);
            this.panel2.Controls.Add(this.maleR);
            this.panel2.Location = new System.Drawing.Point(655, 698);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 68);
            this.panel2.TabIndex = 113;
            // 
            // femaleR
            // 
            this.femaleR.AutoSize = true;
            this.femaleR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.femaleR.Location = new System.Drawing.Point(245, 15);
            this.femaleR.Name = "femaleR";
            this.femaleR.Size = new System.Drawing.Size(126, 33);
            this.femaleR.TabIndex = 80;
            this.femaleR.Text = "Female";
            this.femaleR.UseVisualStyleBackColor = true;
            // 
            // maleR
            // 
            this.maleR.AutoSize = true;
            this.maleR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maleR.Location = new System.Drawing.Point(115, 15);
            this.maleR.Name = "maleR";
            this.maleR.Size = new System.Drawing.Size(97, 33);
            this.maleR.TabIndex = 79;
            this.maleR.Text = "Male";
            this.maleR.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 10.125F);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(991, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 33);
            this.label8.TabIndex = 112;
            this.label8.Text = "Pet Available";
            // 
            // petAvailableValue
            // 
            this.petAvailableValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.petAvailableValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petAvailableValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.petAvailableValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.petAvailableValue.Location = new System.Drawing.Point(956, 232);
            this.petAvailableValue.Name = "petAvailableValue";
            this.petAvailableValue.Size = new System.Drawing.Size(255, 44);
            this.petAvailableValue.TabIndex = 111;
            this.petAvailableValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10.125F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(649, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 33);
            this.label7.TabIndex = 110;
            this.label7.Text = "Pet Price";
            // 
            // petPriceValue
            // 
            this.petPriceValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.petPriceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petPriceValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.petPriceValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.petPriceValue.Location = new System.Drawing.Point(590, 232);
            this.petPriceValue.Name = "petPriceValue";
            this.petPriceValue.Size = new System.Drawing.Size(255, 44);
            this.petPriceValue.TabIndex = 109;
            this.petPriceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.125F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(800, 776);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 33);
            this.label5.TabIndex = 108;
            this.label5.Text = "Pet AgeRange";
            // 
            // editPetBtn
            // 
            this.editPetBtn.BackColor = System.Drawing.Color.Transparent;
            this.editPetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.editPetBtn.FlatAppearance.BorderSize = 2;
            this.editPetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.editPetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.editPetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPetBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.editPetBtn.ForeColor = System.Drawing.Color.Green;
            this.editPetBtn.Location = new System.Drawing.Point(120, 969);
            this.editPetBtn.Name = "editPetBtn";
            this.editPetBtn.Size = new System.Drawing.Size(183, 58);
            this.editPetBtn.TabIndex = 107;
            this.editPetBtn.Text = "Edit Pet";
            this.editPetBtn.UseVisualStyleBackColor = false;
            this.editPetBtn.Click += new System.EventHandler(this.editPetBtn_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.descriptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionText.Font = new System.Drawing.Font("Times New Roman", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionText.ForeColor = System.Drawing.SystemColors.Info;
            this.descriptionText.Location = new System.Drawing.Point(88, 673);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(482, 193);
            this.descriptionText.TabIndex = 106;
            this.descriptionText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.125F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(89, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 33);
            this.label6.TabIndex = 105;
            this.label6.Text = "Pet Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10.125F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(780, 911);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 33);
            this.label4.TabIndex = 104;
            this.label4.Text = "Pet Health Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.125F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(695, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 33);
            this.label3.TabIndex = 103;
            this.label3.Text = "Pet Breed";
            // 
            // petBreedValue
            // 
            this.petBreedValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.petBreedValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petBreedValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.petBreedValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.petBreedValue.Location = new System.Drawing.Point(701, 593);
            this.petBreedValue.Name = "petBreedValue";
            this.petBreedValue.Size = new System.Drawing.Size(413, 44);
            this.petBreedValue.TabIndex = 102;
            this.petBreedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.125F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(808, 659);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 33);
            this.label2.TabIndex = 101;
            this.label2.Text = "Pet Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.125F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(695, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 100;
            this.label1.Text = "Pet Type";
            // 
            // petTypeValue
            // 
            this.petTypeValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.petTypeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petTypeValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.petTypeValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.petTypeValue.Location = new System.Drawing.Point(701, 476);
            this.petTypeValue.Name = "petTypeValue";
            this.petTypeValue.Size = new System.Drawing.Size(413, 44);
            this.petTypeValue.TabIndex = 99;
            this.petTypeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // petNameLabel
            // 
            this.petNameLabel.AutoSize = true;
            this.petNameLabel.Font = new System.Drawing.Font("Century", 10.125F);
            this.petNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.petNameLabel.Location = new System.Drawing.Point(695, 318);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(141, 33);
            this.petNameLabel.TabIndex = 98;
            this.petNameLabel.Text = "Pet Name";
            // 
            // petNameValue
            // 
            this.petNameValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.petNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petNameValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.petNameValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.petNameValue.Location = new System.Drawing.Point(701, 363);
            this.petNameValue.Name = "petNameValue";
            this.petNameValue.Size = new System.Drawing.Size(413, 44);
            this.petNameValue.TabIndex = 97;
            this.petNameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addpetImgBtn
            // 
            this.addpetImgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.addpetImgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addpetImgBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.addpetImgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.addpetImgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.addpetImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addpetImgBtn.Font = new System.Drawing.Font("Century", 10.125F, System.Drawing.FontStyle.Bold);
            this.addpetImgBtn.ForeColor = System.Drawing.Color.Green;
            this.addpetImgBtn.Location = new System.Drawing.Point(95, 498);
            this.addpetImgBtn.Name = "addpetImgBtn";
            this.addpetImgBtn.Size = new System.Drawing.Size(253, 58);
            this.addpetImgBtn.TabIndex = 96;
            this.addpetImgBtn.Text = "Add Pet Img";
            this.addpetImgBtn.UseVisualStyleBackColor = false;
            this.addpetImgBtn.Click += new System.EventHandler(this.addpetImgBtn_Click);
            // 
            // petImg
            // 
            this.petImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petImg.Image = ((System.Drawing.Image)(resources.GetObject("petImg.Image")));
            this.petImg.Location = new System.Drawing.Point(88, 205);
            this.petImg.Name = "petImg";
            this.petImg.Size = new System.Drawing.Size(270, 270);
            this.petImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petImg.TabIndex = 95;
            this.petImg.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.petIdValue);
            this.panel5.Location = new System.Drawing.Point(45, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 66);
            this.panel5.TabIndex = 129;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(81, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Pet Id :";
            // 
            // petIdValue
            // 
            this.petIdValue.AutoSize = true;
            this.petIdValue.ForeColor = System.Drawing.Color.Gold;
            this.petIdValue.Location = new System.Drawing.Point(170, 20);
            this.petIdValue.Name = "petIdValue";
            this.petIdValue.Size = new System.Drawing.Size(113, 25);
            this.petIdValue.TabIndex = 29;
            this.petIdValue.Text = "D1-001-24";
            // 
            // EditPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1340, 1102);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.petAvailableValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.petPriceValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editPetBtn);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.petBreedValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.petTypeValue);
            this.Controls.Add(this.petNameLabel);
            this.Controls.Add(this.petNameValue);
            this.Controls.Add(this.addpetImgBtn);
            this.Controls.Add(this.petImg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petImg)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label formWorkNameLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton fullyVR;
        private System.Windows.Forms.RadioButton partialyVR;
        private System.Windows.Forms.RadioButton noVR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton adultR;
        private System.Windows.Forms.RadioButton puppyR;
        private System.Windows.Forms.RadioButton kittenR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton femaleR;
        private System.Windows.Forms.RadioButton maleR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox petAvailableValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox petPriceValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editPetBtn;
        private System.Windows.Forms.RichTextBox descriptionText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox petBreedValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox petTypeValue;
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.TextBox petNameValue;
        private System.Windows.Forms.Button addpetImgBtn;
        private System.Windows.Forms.PictureBox petImg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label petIdValue;
        private System.Windows.Forms.Label label9;
    }
}