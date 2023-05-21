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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            reservationbt = new Button();
            flightsbt = new Button();
            label2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ageinput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Simple Indust Outline", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(297, 10);
            label1.Name = "label1";
            label1.Size = new Size(486, 50);
            label1.TabIndex = 15;
            label1.Text = "Reservation Flight System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 14);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(reservationbt);
            panel1.Controls.Add(flightsbt);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 488);
            panel1.TabIndex = 14;
            // 
            // reservationbt
            // 
            reservationbt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reservationbt.ForeColor = Color.Teal;
            reservationbt.Location = new Point(7, 154);
            reservationbt.Name = "reservationbt";
            reservationbt.Size = new Size(147, 55);
            reservationbt.TabIndex = 45;
            reservationbt.Text = "My Reservations";
            reservationbt.UseVisualStyleBackColor = true;
            reservationbt.Click += bookbt_Click;
            // 
            // flightsbt
            // 
            flightsbt.BackColor = Color.Transparent;
            flightsbt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            flightsbt.ForeColor = Color.Teal;
            flightsbt.Location = new Point(7, 235);
            flightsbt.Name = "flightsbt";
            flightsbt.Size = new Size(147, 55);
            flightsbt.TabIndex = 46;
            flightsbt.Text = "Flights";
            flightsbt.UseVisualStyleBackColor = false;
            flightsbt.Click += flightsbt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(262, 60);
            label2.Name = "label2";
            label2.Size = new Size(235, 32);
            label2.TabIndex = 16;
            label2.Text = "Passenger Details : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(362, 412);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 39;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(362, 381);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 38;
            label6.Text = "Age";
            // 
            // firstinput
            // 
            firstinput.Location = new Point(362, 197);
            firstinput.Margin = new Padding(3, 2, 3, 2);
            firstinput.Name = "firstinput";
            firstinput.Size = new Size(272, 23);
            firstinput.TabIndex = 31;
            // 
            // ageinput
            // 
            ageinput.Location = new Point(434, 380);
            ageinput.Margin = new Padding(3, 2, 3, 2);
            ageinput.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            ageinput.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            ageinput.Name = "ageinput";
            ageinput.Size = new Size(131, 23);
            ageinput.TabIndex = 37;
            ageinput.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // femaleinput
            // 
            femaleinput.AutoSize = true;
            femaleinput.Location = new Point(510, 410);
            femaleinput.Margin = new Padding(3, 2, 3, 2);
            femaleinput.Name = "femaleinput";
            femaleinput.Size = new Size(63, 19);
            femaleinput.TabIndex = 36;
            femaleinput.TabStop = true;
            femaleinput.Text = "Female";
            femaleinput.UseVisualStyleBackColor = true;
            // 
            // maleinput
            // 
            maleinput.AutoSize = true;
            maleinput.Location = new Point(437, 410);
            maleinput.Margin = new Padding(3, 2, 3, 2);
            maleinput.Name = "maleinput";
            maleinput.Size = new Size(51, 19);
            maleinput.TabIndex = 35;
            maleinput.TabStop = true;
            maleinput.Text = "Male";
            maleinput.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Simple Outline Pat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(362, 225);
            label3.Name = "label3";
            label3.Size = new Size(114, 26);
            label3.TabIndex = 34;
            label3.Text = "Last Name";
            // 
            // lastinput
            // 
            lastinput.Location = new Point(362, 251);
            lastinput.Margin = new Padding(3, 2, 3, 2);
            lastinput.Name = "lastinput";
            lastinput.Size = new Size(272, 23);
            lastinput.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Simple Outline Pat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(362, 171);
            label5.Name = "label5";
            label5.Size = new Size(115, 26);
            label5.TabIndex = 32;
            label5.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Simple Outline Pat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(362, 327);
            label4.Name = "label4";
            label4.Size = new Size(57, 26);
            label4.TabIndex = 30;
            label4.Text = "SSN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Simple Outline Pat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(362, 278);
            label8.Name = "label8";
            label8.Size = new Size(177, 26);
            label8.TabIndex = 29;
            label8.Text = "Passport Number";
            // 
            // ssninput
            // 
            ssninput.Location = new Point(362, 353);
            ssninput.Margin = new Padding(3, 2, 3, 2);
            ssninput.Name = "ssninput";
            ssninput.PasswordChar = '*';
            ssninput.Size = new Size(272, 23);
            ssninput.TabIndex = 28;
            // 
            // portinput
            // 
            portinput.Location = new Point(362, 302);
            portinput.Margin = new Padding(3, 2, 3, 2);
            portinput.Name = "portinput";
            portinput.Size = new Size(272, 23);
            portinput.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(397, 437);
            button1.Name = "button1";
            button1.Size = new Size(142, 39);
            button1.TabIndex = 40;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flightidinput
            // 
            flightidinput.Location = new Point(362, 138);
            flightidinput.Margin = new Padding(3, 2, 3, 2);
            flightidinput.Name = "flightidinput";
            flightidinput.Size = new Size(272, 23);
            flightidinput.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Simple Outline Pat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(362, 112);
            label9.Name = "label9";
            label9.Size = new Size(86, 26);
            label9.TabIndex = 42;
            label9.Text = "FlightID";
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(887, 488);
            MinimumSize = new Size(1918, 1078);
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Book";
            Text = "Book";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ageinput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
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
    }
}