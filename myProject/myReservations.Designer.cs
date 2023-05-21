namespace myProject
{
    partial class myReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myReservations));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            flightsbt = new Button();
            bookbt = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Simple Indust Outline", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(486, 50);
            label1.TabIndex = 17;
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
            panel1.Controls.Add(flightsbt);
            panel1.Controls.Add(bookbt);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 479);
            panel1.TabIndex = 16;
            // 
            // flightsbt
            // 
            flightsbt.BackColor = Color.Transparent;
            flightsbt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            flightsbt.ForeColor = Color.Teal;
            flightsbt.Location = new Point(7, 235);
            flightsbt.Name = "flightsbt";
            flightsbt.Size = new Size(147, 55);
            flightsbt.TabIndex = 45;
            flightsbt.Text = "Flights";
            flightsbt.UseVisualStyleBackColor = false;
            flightsbt.Click += flightsbt_Click;
            // 
            // bookbt
            // 
            bookbt.BackColor = Color.Transparent;
            bookbt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookbt.ForeColor = Color.Teal;
            bookbt.Location = new Point(7, 154);
            bookbt.Name = "bookbt";
            bookbt.Size = new Size(147, 55);
            bookbt.TabIndex = 44;
            bookbt.Text = "Book Ticket";
            bookbt.UseVisualStyleBackColor = false;
            bookbt.Click += bookbt_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 143);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Simple Outline Pat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(203, 117);
            label5.Name = "label5";
            label5.Size = new Size(91, 26);
            label5.TabIndex = 36;
            label5.Text = "Flight ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Simple Outline Pat", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(203, 178);
            label4.Name = "label4";
            label4.Size = new Size(87, 26);
            label4.TabIndex = 34;
            label4.Text = "Book ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 204);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(145, 23);
            textBox2.TabIndex = 33;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.MintCream;
            button2.Location = new Point(208, 251);
            button2.Name = "button2";
            button2.Size = new Size(130, 39);
            button2.TabIndex = 42;
            button2.Text = "Cancle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Cornsilk;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(390, 61);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 100;
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 70;
            dataGridView1.Size = new Size(491, 407);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // myReservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(893, 479);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.Cornsilk;
            Name = "myReservations";
            Text = "My Reservations";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private Button bookbt;
        private Button flightsbt;
        private DataGridView dataGridView1;
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                // Apply color to even rows
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Teal;
            }
            else
            {
                // Apply color to odd rows
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {


                // Custom header design
                using (Brush headerBrush = new SolidBrush(Color.Navy))
                using (Brush textBrush = new SolidBrush(Color.White))

                {
                    e.Graphics.FillRectangle(headerBrush, e.CellBounds);
                    e.Graphics.DrawString(e.Value?.ToString(), e.CellStyle.Font, textBrush, e.CellBounds, new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    });
                }

                e.Handled = true; // Prevent default header painting


            }



        }
    }
}