using System.Runtime.InteropServices;

namespace myProject
{
    partial class AdminAircraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAircraft));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            update = new Button();
            label1 = new Label();
            panel1 = new Panel();
            Flights = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            textBoxSize = new TextBox();
            dataGridView1 = new DataGridView();
            textBoxID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBoxSeats = new TextBox();
            textBoxKind = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(100, 200, 200);
            update.FlatStyle = FlatStyle.Flat;
            update.ForeColor = Color.White;
            update.Location = new Point(380, 679);
            update.Name = "update";
            update.Size = new Size(124, 45);
            update.TabIndex = 53;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(225, 87);
            label1.Name = "label1";
            label1.Size = new Size(439, 39);
            label1.TabIndex = 45;
            label1.Text = "Reservation Flight System";
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(Flights);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 1033);
            panel1.TabIndex = 44;
            // 
            // Flights
            // 
            Flights.BackColor = Color.White;
            Flights.FlatAppearance.BorderSize = 0;
            Flights.FlatStyle = FlatStyle.Flat;
            Flights.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Flights.ForeColor = Color.Teal;
            Flights.Location = new Point(24, 220);
            Flights.Name = "Flights";
            Flights.Size = new Size(127, 42);
            Flights.TabIndex = 58;
            Flights.Text = "Flights";
            Flights.UseVisualStyleBackColor = false;
            Flights.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(225, 555);
            label7.Name = "label7";
            label7.Size = new Size(55, 25);
            label7.TabIndex = 56;
            label7.Text = "Size";
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(225, 607);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(279, 27);
            textBoxSize.TabIndex = 55;
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
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(616, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 100;
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 70;
            dataGridView1.Size = new Size(1134, 795);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // textBoxID
            // 
            textBoxID.BackColor = Color.White;
            textBoxID.Location = new Point(225, 275);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(279, 27);
            textBoxID.TabIndex = 50;
            textBoxID.TextChanged += textBoxID_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(225, 230);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 51;
            label5.Text = "Aircraft ID";
            label5.Click += label5_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(225, 444);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 49;
            label4.Text = "Seats";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(225, 343);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 48;
            label2.Text = "Kind";
            // 
            // textBoxSeats
            // 
            textBoxSeats.Location = new Point(225, 496);
            textBoxSeats.Name = "textBoxSeats";
            textBoxSeats.Size = new Size(279, 27);
            textBoxSeats.TabIndex = 47;
            textBoxSeats.TextChanged += textBoxSeats_TextChanged;
            // 
            // textBoxKind
            // 
            textBoxKind.Location = new Point(225, 387);
            textBoxKind.Name = "textBoxKind";
            textBoxKind.Size = new Size(279, 27);
            textBoxKind.TabIndex = 46;
            textBoxKind.TextChanged += textBoxsrc_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(225, 679);
            button1.Name = "button1";
            button1.Size = new Size(124, 45);
            button1.TabIndex = 57;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1599, 87);
            button2.Name = "button2";
            button2.Size = new Size(151, 46);
            button2.TabIndex = 58;
            button2.Text = "Sign Out ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // AdminAircraft
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(update);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(textBoxSize);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBoxSeats);
            Controls.Add(textBoxKind);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1280, 720);
            Name = "AdminAircraft";
            Text = "AdminAircraft";
            Load += AdminAircraft_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button update;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox textBoxSize;
        private DataGridView dataGridView1;
        private TextBox textBoxID;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox textBoxSeats;
        private TextBox textBoxKind;
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

        private Button button1;
        private Button Flights;
        private Button button2;
    }

}