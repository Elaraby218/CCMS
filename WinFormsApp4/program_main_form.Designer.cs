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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program_main_form));
            History = new Button();
            Log_out_btn = new Button();
            emp_name = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            Reg_newstudbtn = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel7 = new Panel();
            StudNational_txtbox = new TextBox();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            IdSTU = new DataGridViewTextBoxColumn();
            NameSTU = new DataGridViewTextBoxColumn();
            FacultySTU = new DataGridViewTextBoxColumn();
            LevelSTU = new DataGridViewTextBoxColumn();
            In_timeSTU = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            panel4 = new Panel();
            button9 = new Button();
            pictureBox2 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // History
            // 
            History.BackColor = SystemColors.ControlDarkDark;
            History.Cursor = Cursors.SizeAll;
            History.FlatStyle = FlatStyle.Popup;
            History.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            History.ForeColor = SystemColors.ButtonHighlight;
            History.Location = new Point(12, 556);
            History.Name = "History";
            History.Size = new Size(147, 46);
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
            Log_out_btn.Location = new Point(12, 360);
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
            pictureBox1.Location = new Point(32, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkSeaGreen;
            textBox1.Location = new Point(32, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
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
            panel1.Size = new Size(176, 487);
            panel1.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 158);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 15, 0);
            button3.Size = new Size(147, 48);
            button3.TabIndex = 6;
            button3.Text = "Account";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 226);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 25, 0);
            button2.Size = new Size(147, 48);
            button2.TabIndex = 5;
            button2.Text = "Print";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 293);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 15, 0);
            button1.Size = new Size(147, 48);
            button1.TabIndex = 4;
            button1.Text = "Setting";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 69);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(Reg_newstudbtn);
            panel6.Controls.Add(button4);
            panel6.Controls.Add(button5);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 429);
            panel6.Name = "panel6";
            panel6.Size = new Size(660, 58);
            panel6.TabIndex = 21;
            // 
            // Reg_newstudbtn
            // 
            Reg_newstudbtn.BackColor = Color.SeaGreen;
            Reg_newstudbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Reg_newstudbtn.ForeColor = SystemColors.ButtonHighlight;
            Reg_newstudbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Reg_newstudbtn.Location = new Point(202, 10);
            Reg_newstudbtn.Name = "Reg_newstudbtn";
            Reg_newstudbtn.Size = new Size(155, 36);
            Reg_newstudbtn.TabIndex = 21;
            Reg_newstudbtn.Text = "New Student";
            Reg_newstudbtn.UseVisualStyleBackColor = false;
            Reg_newstudbtn.Click += Reg_newstudbtn_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(21, 10);
            button4.Name = "button4";
            button4.Size = new Size(155, 36);
            button4.TabIndex = 19;
            button4.Text = "Add Student";
            button4.UseVisualStyleBackColor = false;
            button4.Click += AddStudBtn;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 0, 0);
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(390, 10);
            button5.Name = "button5";
            button5.Size = new Size(155, 36);
            button5.TabIndex = 20;
            button5.Text = "Remove Student";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(186, 45);
            label1.TabIndex = 11;
            label1.Text = "DashBoard";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Cursor = Cursors.Cross;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(176, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(660, 487);
            panel3.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.Controls.Add(StudNational_txtbox);
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 388);
            panel7.Name = "panel7";
            panel7.Size = new Size(660, 41);
            panel7.TabIndex = 33;
            // 
            // StudNational_txtbox
            // 
            StudNational_txtbox.Location = new Point(202, 6);
            StudNational_txtbox.Name = "StudNational_txtbox";
            StudNational_txtbox.Size = new Size(258, 23);
            StudNational_txtbox.TabIndex = 29;
            StudNational_txtbox.TextChanged += StudNational_txtbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaGreen;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 31;
            label2.Text = "Enter Student National Id";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IdSTU, NameSTU, FacultySTU, LevelSTU, In_timeSTU });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.GridColor = SystemColors.ButtonHighlight;
            dataGridView2.Location = new Point(0, 66);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(660, 363);
            dataGridView2.TabIndex = 32;
            // 
            // IdSTU
            // 
            IdSTU.HeaderText = "National Id";
            IdSTU.Name = "IdSTU";
            IdSTU.ReadOnly = true;
            // 
            // NameSTU
            // 
            NameSTU.HeaderText = "Name";
            NameSTU.Name = "NameSTU";
            NameSTU.ReadOnly = true;
            // 
            // FacultySTU
            // 
            FacultySTU.HeaderText = "Faculty";
            FacultySTU.Name = "FacultySTU";
            FacultySTU.ReadOnly = true;
            // 
            // LevelSTU
            // 
            LevelSTU.HeaderText = "Level";
            LevelSTU.Name = "LevelSTU";
            LevelSTU.ReadOnly = true;
            // 
            // In_timeSTU
            // 
            In_timeSTU.HeaderText = "Time in";
            In_timeSTU.Name = "In_timeSTU";
            In_timeSTU.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(pictureBox2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(660, 66);
            panel5.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.Controls.Add(button9);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(480, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 66);
            panel4.TabIndex = 27;
            panel4.Paint += panel4_Paint;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlDarkDark;
            button9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(0, 381);
            button9.Name = "button9";
            button9.Size = new Size(221, 37);
            button9.TabIndex = 6;
            button9.Text = "Check Connection";
            button9.UseVisualStyleBackColor = false;
            button9.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location = new Point(202, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // program_main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 487);
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
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Panel panel5;
        private Button button9;
        private Panel panel6;
        private PictureBox pictureBox2;
        private TextBox StudNational_txtbox;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private Button Reg_newstudbtn;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn IdSTU;
        private DataGridViewTextBoxColumn NameSTU;
        private DataGridViewTextBoxColumn FacultySTU;
        private DataGridViewTextBoxColumn LevelSTU;
        private DataGridViewTextBoxColumn In_timeSTU;
        private Panel panel7;
    }

}