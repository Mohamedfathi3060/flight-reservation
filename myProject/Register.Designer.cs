﻿namespace myProject
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            linkLabel1 = new LinkLabel();
            btlogin = new Button();
            label4 = new Label();
            label2 = new Label();
            textBoxpass = new TextBox();
            textBoxusername = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            textBoxfname = new TextBox();
            label3 = new Label();
            textBoxlname = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textage = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textage).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.LightSeaGreen;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Teal;
            linkLabel1.Location = new Point(592, 711);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(149, 20);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "aleardy have account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btlogin
            // 
            btlogin.FlatAppearance.BorderColor = Color.Teal;
            btlogin.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            btlogin.FlatStyle = FlatStyle.Flat;
            btlogin.Font = new Font("Simple Outline Pat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btlogin.ForeColor = Color.Teal;
            btlogin.Location = new Point(576, 657);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(196, 40);
            btlogin.TabIndex = 16;
            btlogin.Text = "Register";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Simple Outline Pat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(521, 434);
            label4.Name = "label4";
            label4.Size = new Size(134, 33);
            label4.TabIndex = 15;
            label4.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simple Outline Pat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(521, 346);
            label2.Name = "label2";
            label2.Size = new Size(150, 33);
            label2.TabIndex = 14;
            label2.Text = "User Name";
            // 
            // textBoxpass
            // 
            textBoxpass.Location = new Point(521, 470);
            textBoxpass.Name = "textBoxpass";
            textBoxpass.PasswordChar = '*';
            textBoxpass.Size = new Size(310, 27);
            textBoxpass.TabIndex = 13;
            // 
            // textBoxusername
            // 
            textBoxusername.Location = new Point(521, 382);
            textBoxusername.Name = "textBoxusername";
            textBoxusername.Size = new Size(310, 27);
            textBoxusername.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Simple Indust Outline", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(414, 19);
            label1.Name = "label1";
            label1.Size = new Size(601, 62);
            label1.TabIndex = 11;
            label1.Text = "Reservation Flight System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 824);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Simple Outline Pat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(521, 146);
            label5.Name = "label5";
            label5.Size = new Size(147, 33);
            label5.TabIndex = 19;
            label5.Text = "First Name";
            // 
            // textBoxfname
            // 
            textBoxfname.Location = new Point(521, 182);
            textBoxfname.Name = "textBoxfname";
            textBoxfname.Size = new Size(310, 27);
            textBoxfname.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Simple Outline Pat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(521, 242);
            label3.Name = "label3";
            label3.Size = new Size(145, 33);
            label3.TabIndex = 21;
            label3.Text = "Last Name";
            // 
            // textBoxlname
            // 
            textBoxlname.Location = new Point(521, 278);
            textBoxlname.Name = "textBoxlname";
            textBoxlname.Size = new Size(310, 27);
            textBoxlname.TabIndex = 20;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(603, 591);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 22;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(687, 591);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 23;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textage
            // 
            textage.Location = new Point(604, 525);
            textage.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            textage.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            textage.Name = "textage";
            textage.Size = new Size(150, 27);
            textage.TabIndex = 24;
            textage.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(521, 527);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 25;
            label6.Text = "Age";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(518, 593);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 26;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Simple Outline Pat", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(665, 357);
            label8.Name = "label8";
            label8.Size = new Size(155, 22);
            label8.TabIndex = 27;
            label8.Text = "or SSN for Admins";
            // 
            // Register
            // 


            MinimumSize = new Size(1918, 1078);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1286, 824);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxfname);
            Controls.Add(textage);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(textBoxlname);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(btlogin);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBoxpass);
            Controls.Add(textBoxusername);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            Load += register_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button btlogin;
        private Label label4;
        private Label label2;
        private TextBox textBoxpass;
        private TextBox textBoxusername;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox textBoxfname;
        private Label label3;
        private TextBox textBoxlname;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private NumericUpDown textage;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}