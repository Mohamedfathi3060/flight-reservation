namespace myProject
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            reservationbt = new Button();
            flightsbt = new Button();
            label7 = new Label();
            label6 = new Label();
            firstinput = new TextBox();
            ageinput = new NumericUpDown();
            femaleinput = new RadioButton();
            maleinput = new RadioButton();
            label3 = new Label();
            lastinput = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            ssninput = new TextBox();
            portinput = new TextBox();
            button1 = new Button();
            flightidinput = new TextBox();
            label9 = new Label();
            button2 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ageinput).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(reservationbt);
            panel1.Controls.Add(flightsbt);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 1033);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // reservationbt
            // 
            reservationbt.BackColor = Color.White;
            reservationbt.FlatAppearance.BorderSize = 0;
            reservationbt.FlatStyle = FlatStyle.Flat;
            reservationbt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reservationbt.ForeColor = Color.Teal;
            reservationbt.Location = new Point(8, 205);
            reservationbt.Margin = new Padding(3, 4, 3, 4);
            reservationbt.Name = "reservationbt";
            reservationbt.Size = new Size(174, 64);
            reservationbt.TabIndex = 45;
            reservationbt.Text = "My Reservations";
            reservationbt.UseVisualStyleBackColor = false;
            reservationbt.Click += bookbt_Click;
            // 
            // flightsbt
            // 
            flightsbt.BackColor = Color.White;
            flightsbt.FlatAppearance.BorderSize = 0;
            flightsbt.FlatStyle = FlatStyle.Flat;
            flightsbt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            flightsbt.ForeColor = Color.Teal;
            flightsbt.Location = new Point(8, 313);
            flightsbt.Margin = new Padding(3, 4, 3, 4);
            flightsbt.Name = "flightsbt";
            flightsbt.Size = new Size(168, 73);
            flightsbt.TabIndex = 46;
            flightsbt.Text = "Flights";
            flightsbt.UseVisualStyleBackColor = false;
            flightsbt.Click += flightsbt_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(296, 643);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 39;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(299, 573);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 38;
            label6.Text = "Age";
            // 
            // firstinput
            // 
            firstinput.Location = new Point(296, 265);
            firstinput.Name = "firstinput";
            firstinput.Size = new Size(310, 27);
            firstinput.TabIndex = 31;
            firstinput.TextChanged += firstinput_TextChanged;
            // 
            // ageinput
            // 
            ageinput.Location = new Point(381, 571);
            ageinput.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            ageinput.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            ageinput.Name = "ageinput";
            ageinput.Size = new Size(150, 27);
            ageinput.TabIndex = 37;
            ageinput.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // femaleinput
            // 
            femaleinput.AutoSize = true;
            femaleinput.Location = new Point(465, 641);
            femaleinput.Name = "femaleinput";
            femaleinput.Size = new Size(78, 24);
            femaleinput.TabIndex = 36;
            femaleinput.TabStop = true;
            femaleinput.Text = "Female";
            femaleinput.UseVisualStyleBackColor = true;
            // 
            // maleinput
            // 
            maleinput.AutoSize = true;
            maleinput.Location = new Point(381, 641);
            maleinput.Name = "maleinput";
            maleinput.Size = new Size(63, 24);
            maleinput.TabIndex = 35;
            maleinput.TabStop = true;
            maleinput.Text = "Male";
            maleinput.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(296, 304);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 34;
            label3.Text = "Last Name";
            // 
            // lastinput
            // 
            lastinput.Location = new Point(296, 348);
            lastinput.Name = "lastinput";
            lastinput.Size = new Size(310, 27);
            lastinput.TabIndex = 33;
            lastinput.TextChanged += lastinput_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(296, 226);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 32;
            label5.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(296, 480);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 30;
            label4.Text = "SSN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(296, 389);
            label8.Name = "label8";
            label8.Size = new Size(178, 25);
            label8.TabIndex = 29;
            label8.Text = "Passport Number";
            // 
            // ssninput
            // 
            ssninput.Location = new Point(296, 521);
            ssninput.Name = "ssninput";
            ssninput.Size = new Size(310, 27);
            ssninput.TabIndex = 28;
            // 
            // portinput
            // 
            portinput.Location = new Point(296, 429);
            portinput.Name = "portinput";
            portinput.Size = new Size(310, 27);
            portinput.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(336, 722);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 52);
            button1.TabIndex = 40;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flightidinput
            // 
            flightidinput.Location = new Point(296, 181);
            flightidinput.Name = "flightidinput";
            flightidinput.Size = new Size(310, 27);
            flightidinput.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(296, 140);
            label9.Name = "label9";
            label9.Size = new Size(86, 25);
            label9.TabIndex = 42;
            label9.Text = "FlightID";
            label9.Click += label9_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1190, 58);
            button2.Name = "button2";
            button2.Size = new Size(151, 46);
            button2.TabIndex = 59;
            button2.Text = "Sign Out ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Bahnschrift Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(419, 32);
            label1.Name = "label1";
            label1.Size = new Size(551, 72);
            label1.TabIndex = 83;
            label1.Text = "Reservation Flight System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(flightidinput);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(firstinput);
            Controls.Add(ageinput);
            Controls.Add(femaleinput);
            Controls.Add(maleinput);
            Controls.Add(label3);
            Controls.Add(lastinput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(ssninput);
            Controls.Add(portinput);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1918, 1028);
            Name = "Book";
            Text = "Book";
            Load += Book_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ageinput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label7;
        private Label label6;
        private TextBox firstinput;
        private NumericUpDown ageinput;
        private RadioButton femaleinput;
        private RadioButton maleinput;
        private Label label3;
        private TextBox lastinput;
        private Label label5;
        private Label label4;
        private Label label8;
        private TextBox ssninput;
        private TextBox portinput;
        private Button button1;
        private Button flightsbt;
        private Button reservationbt;
        private TextBox flightidinput;
        private Label label9;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label1;
    }
}