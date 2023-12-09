using WinFormsApp4.data;
namespace WinFormsApp4
{
    partial class Login_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        AppDbContext db = AppDbContext.Instance;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label8 = new Label();
            label6 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(291, 208);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 30);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(291, 272);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(242, 30);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(291, 353);
            button1.Name = "button1";
            button1.Size = new Size(242, 37);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.SeaGreen;
            linkLabel1.Location = new Point(291, 393);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(102, 17);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(304, 144);
            label8.Name = "label8";
            label8.Size = new Size(219, 30);
            label8.TabIndex = 21;
            label8.Text = "Login to Your Account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(291, 189);
            label6.Name = "label6";
            label6.Size = new Size(75, 16);
            label6.TabIndex = 23;
            label6.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(291, 253);
            label1.Name = "label1";
            label1.Size = new Size(70, 16);
            label1.TabIndex = 22;
            label1.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaGreen;
            pictureBox1.Image = Properties.Resources.icons8_person_642;
            pictureBox1.Location = new Point(349, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.SeaGreen;
            linkLabel2.Location = new Point(421, 393);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(112, 17);
            linkLabel2.TabIndex = 25;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forget Password?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(646, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 501);
            panel1.TabIndex = 26;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaGreen;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.ControlDarkDark;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(137, 3);
            button4.Name = "button4";
            button4.Size = new Size(34, 30);
            button4.TabIndex = 32;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = Properties.Resources.icons8_minus_24;
            button3.Location = new Point(36, 3);
            button3.Name = "button3";
            button3.Size = new Size(34, 30);
            button3.TabIndex = 31;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SeaGreen;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.ControlDarkDark;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(87, 3);
            button5.Name = "button5";
            button5.Size = new Size(34, 30);
            button5.TabIndex = 30;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(0, 381);
            button2.Name = "button2";
            button2.Size = new Size(221, 37);
            button2.TabIndex = 6;
            button2.Text = "Check Connection";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location = new Point(-33, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(298, 239);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(646, 501);
            panel2.TabIndex = 34;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 501);
            panel3.TabIndex = 35;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 501);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            Load += Login_Page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label8;
        private Label label6;
        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel2;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button5;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
    }
}