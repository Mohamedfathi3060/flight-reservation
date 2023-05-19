namespace myProject
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            // textBox2
            // 
            textBox2.Location = new Point(521, 470);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(310, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(521, 382);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 27);
            textBox1.TabIndex = 12;
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
            // textBox3
            // 
            textBox3.Location = new Point(521, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(310, 27);
            textBox3.TabIndex = 18;
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
            // textBox4
            // 
            textBox4.Location = new Point(521, 278);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(310, 27);
            textBox4.TabIndex = 20;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(604, 525);
            numericUpDown1.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 24;
            numericUpDown1.Value = new decimal(new int[] { 18, 0, 0, 0 });
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
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1286, 824);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(btlogin);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            Load += register_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button btlogin;
        private Label label4;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label7;
    }
}