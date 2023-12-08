using WinFormsApp4;
using WinFormsApp4.data;
namespace WinFormsApp4
{
    partial class program_main_form
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
        AppDbContext db = AppDbContext.Instance;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program_main_form));
            History = new Button();
            Log_out_btn = new Button();
            emp_name = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // History
            // 
            History.BackColor = SystemColors.ControlDarkDark;
            History.Cursor = Cursors.SizeAll;
            History.FlatStyle = FlatStyle.Popup;
            History.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            History.ForeColor = SystemColors.ButtonHighlight;
            History.Location = new Point(12, 495);
            History.Name = "History";
            History.Size = new Size(166, 46);
            History.TabIndex = 3;
            History.Text = "History";
            History.UseVisualStyleBackColor = false;
            History.Click += History_Click;
            // 
            // Log_out_btn
            // 
            Log_out_btn.BackColor = Color.SeaGreen;
            Log_out_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Log_out_btn.ForeColor = SystemColors.ButtonHighlight;
            Log_out_btn.Image = Properties.Resources.icons8_logout_24;
            Log_out_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Log_out_btn.Location = new Point(22, 361);
            Log_out_btn.Name = "Log_out_btn";
            Log_out_btn.Padding = new Padding(15, 0, 15, 0);
            Log_out_btn.Size = new Size(147, 48);
            Log_out_btn.TabIndex = 0;
            Log_out_btn.Text = "Log out";
            Log_out_btn.TextAlign = ContentAlignment.MiddleRight;
            Log_out_btn.UseVisualStyleBackColor = false;
            Log_out_btn.Click += Log_out_btn_Click;
            // 
            // emp_name
            // 
            emp_name.AutoSize = true;
            emp_name.BackColor = Color.DarkSlateBlue;
            emp_name.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            emp_name.ForeColor = SystemColors.ButtonHighlight;
            emp_name.Location = new Point(22, 237);
            emp_name.Name = "emp_name";
            emp_name.Size = new Size(0, 25);
            emp_name.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaGreen;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(65, 20);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 26);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Log_out_btn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(History);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(50, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 553);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 69);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(dataGridView1);
            panel3.Cursor = Cursors.Cross;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(218, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(608, 553);
            panel3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(457, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 45);
            label1.TabIndex = 11;
            label1.Text = "DashBoard";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(599, 359);
            dataGridView1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaGreen;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(97, 444);
            button4.Name = "button4";
            button4.Size = new Size(155, 61);
            button4.TabIndex = 19;
            button4.Text = "Add Student";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.SeaGreen;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(347, 444);
            button5.Name = "button5";
            button5.Size = new Size(155, 61);
            button5.TabIndex = 20;
            button5.Text = "Remove Student";
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(22, 292);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 15, 0);
            button1.Size = new Size(147, 48);
            button1.TabIndex = 4;
            button1.Text = "Setting";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(22, 226);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 25, 0);
            button2.Size = new Size(147, 48);
            button2.TabIndex = 5;
            button2.Text = "Print";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(22, 161);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 15, 0);
            button3.Size = new Size(147, 48);
            button3.TabIndex = 6;
            button3.Text = "Account";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // program_main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 553);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(emp_name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "program_main_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "program_main_form";
            Load += program_main_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Log_out_btn;
        private Label emp_name;
        private string employee_n_id;
        private string name_label_text;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button History;
        private Label label1;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
    }

}