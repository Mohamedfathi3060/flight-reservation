namespace myProject
{
    partial class adminFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminFlight));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            aircraft = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            textBoxID = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBoxdest = new TextBox();
            textBoxsrc = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            textBoxflightId = new TextBox();
            button1 = new Button();
            update = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(288, 29);
            label1.Name = "label1";
            label1.Size = new Size(439, 39);
            label1.TabIndex = 11;
            label1.Text = "Reservation Flight System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(aircraft);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 1033);
            panel1.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Teal;
            button3.Location = new Point(26, 367);
            button3.Name = "button3";
            button3.Size = new Size(138, 49);
            button3.TabIndex = 5;
            button3.Text = "Stats";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // aircraft
            // 
            aircraft.BackColor = Color.White;
            aircraft.FlatAppearance.BorderSize = 0;
            aircraft.FlatStyle = FlatStyle.Flat;
            aircraft.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            aircraft.ForeColor = Color.Teal;
            aircraft.Location = new Point(26, 251);
            aircraft.Name = "aircraft";
            aircraft.Size = new Size(138, 49);
            aircraft.TabIndex = 4;
            aircraft.Text = "Aircraft";
            aircraft.UseVisualStyleBackColor = false;
            aircraft.Click += button2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(288, 698);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 35;
            label6.Text = "Class";
            // 
            // textBoxID
            // 
            textBoxID.BackColor = Color.White;
            textBoxID.Location = new Point(288, 230);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(279, 27);
            textBoxID.TabIndex = 30;
            textBoxID.TextChanged += textBoxID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(288, 580);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 33;
            label3.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(288, 181);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 31;
            label5.Text = "Fligh ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(288, 391);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 29;
            label4.Text = "destination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(288, 287);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 28;
            label2.Text = "source";
            label2.Click += label2_Click;
            // 
            // textBoxdest
            // 
            textBoxdest.Location = new Point(290, 435);
            textBoxdest.Name = "textBoxdest";
            textBoxdest.Size = new Size(279, 27);
            textBoxdest.TabIndex = 27;
            textBoxdest.TextChanged += textBox2_TextChanged;
            // 
            // textBoxsrc
            // 
            textBoxsrc.Location = new Point(290, 332);
            textBoxsrc.Name = "textBoxsrc";
            textBoxsrc.Size = new Size(279, 27);
            textBoxsrc.TabIndex = 26;
            textBoxsrc.TextChanged += textBoxsrc_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(288, 629);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 36;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Economic", "Fisrt-Class", "business" });
            comboBox1.Location = new Point(372, 698);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 37;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            dataGridView1.Location = new Point(623, 169);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(288, 489);
            label7.Name = "label7";
            label7.Size = new Size(108, 25);
            label7.TabIndex = 43;
            label7.Text = "Aircraft ID";
            // 
            // textBoxflightId
            // 
            textBoxflightId.Location = new Point(288, 531);
            textBoxflightId.Name = "textBoxflightId";
            textBoxflightId.Size = new Size(279, 27);
            textBoxflightId.TabIndex = 42;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(288, 761);
            button1.Name = "button1";
            button1.Size = new Size(124, 45);
            button1.TabIndex = 59;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(100, 200, 200);
            update.FlatStyle = FlatStyle.Flat;
            update.ForeColor = Color.White;
            update.Location = new Point(445, 761);
            update.Name = "update";
            update.Size = new Size(124, 45);
            update.TabIndex = 58;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1606, 29);
            button2.Name = "button2";
            button2.Size = new Size(151, 46);
            button2.TabIndex = 60;
            button2.Text = "Sign Out ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_2;
            // 
            // adminFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(update);
            Controls.Add(label7);
            Controls.Add(textBoxflightId);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(textBoxID);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBoxdest);
            Controls.Add(textBoxsrc);
            Controls.Add(label1);
            Controls.Add(panel1);
            MinimumSize = new Size(1918, 1028);
            Name = "adminFlight";
            Text = "adminFlight";
            Load += adminFlight_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label6;
        private TextBox textBoxID;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox textBoxdest;
        private TextBox textBoxsrc;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
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

        private Label label7;
        private TextBox textBoxflightId;
        private PictureBox pictureBox1;
        private Button button1;
        private Button update;
        private Button aircraft;
        private Button button2;
        private Button button3;
    }
}

/*
 dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ControlText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Teal;
            dataGridView1.Location = new Point(630, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 100;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(644, 532);
            dataGridView1.TabIndex = 41;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None ;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Enable text wrapping
            dataGridView1.RowTemplate.Height = 50; // Set the desired row height
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



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
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                // Custom header design
                using (Brush headerBrush = new SolidBrush(Color.Red))
                using (Brush textBrush = new SolidBrush(Color.White))
                using (Pen borderPen = new Pen(Color.Black))
                {
                    e.Graphics.FillRectangle(headerBrush, e.CellBounds);
                    e.Graphics.DrawString(e.Value?.ToString(), e.CellStyle.Font, textBrush, e.CellBounds, new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    });
                    e.Graphics.DrawRectangle(borderPen, e.CellBounds);
                }

                e.Handled = true; // Prevent default header painting
            }
        }

 */