using WinFormsApp4.data;
namespace WinFormsApp4
{
    partial class Sign_up_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_up_form));
            label1 = new Label();
            name_txtbox = new TextBox();
            label2 = new Label();
            phone_num_txtbox = new TextBox();
            label3 = new Label();
            password_txtbox = new TextBox();
            label4 = new Label();
            email_txtbox = new TextBox();
            label5 = new Label();
            cpass_txtbox = new TextBox();
            label6 = new Label();
            National_id_txtbox = new TextBox();
            label7 = new Label();
            user_txtbox = new TextBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(293, 125);
            label1.Name = "label1";
            label1.Size = new Size(42, 16);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // name_txtbox
            // 
            name_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            name_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            name_txtbox.Location = new Point(293, 147);
            name_txtbox.Multiline = true;
            name_txtbox.Name = "name_txtbox";
            name_txtbox.Size = new Size(189, 30);
            name_txtbox.TabIndex = 3;
            name_txtbox.TextAlign = HorizontalAlignment.Center;
            name_txtbox.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(545, 198);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // phone_num_txtbox
            // 
            phone_num_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            phone_num_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            phone_num_txtbox.Location = new Point(293, 293);
            phone_num_txtbox.Multiline = true;
            phone_num_txtbox.Name = "phone_num_txtbox";
            phone_num_txtbox.Size = new Size(189, 30);
            phone_num_txtbox.TabIndex = 5;
            phone_num_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(296, 343);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // password_txtbox
            // 
            password_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            password_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            password_txtbox.Location = new Point(540, 217);
            password_txtbox.Multiline = true;
            password_txtbox.Name = "password_txtbox";
            password_txtbox.PasswordChar = '*';
            password_txtbox.Size = new Size(182, 30);
            password_txtbox.TabIndex = 7;
            password_txtbox.TextAlign = HorizontalAlignment.Center;
            password_txtbox.TextChanged += password_txtbox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(293, 198);
            label4.Name = "label4";
            label4.Size = new Size(74, 16);
            label4.TabIndex = 10;
            label4.Text = "National id";
            // 
            // email_txtbox
            // 
            email_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            email_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            email_txtbox.Location = new Point(293, 362);
            email_txtbox.Multiline = true;
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Size = new Size(429, 30);
            email_txtbox.TabIndex = 9;
            email_txtbox.TextAlign = HorizontalAlignment.Center;
            email_txtbox.TextChanged += email_txtbox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(540, 274);
            label5.Name = "label5";
            label5.Size = new Size(132, 16);
            label5.TabIndex = 12;
            label5.Text = "Re-Enter Password";
            // 
            // cpass_txtbox
            // 
            cpass_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cpass_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            cpass_txtbox.Location = new Point(540, 293);
            cpass_txtbox.Multiline = true;
            cpass_txtbox.Name = "cpass_txtbox";
            cpass_txtbox.PasswordChar = '*';
            cpass_txtbox.Size = new Size(182, 30);
            cpass_txtbox.TabIndex = 11;
            cpass_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(540, 125);
            label6.Name = "label6";
            label6.Size = new Size(75, 16);
            label6.TabIndex = 14;
            label6.Text = "User Name";
            // 
            // National_id_txtbox
            // 
            National_id_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            National_id_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            National_id_txtbox.Location = new Point(293, 217);
            National_id_txtbox.Multiline = true;
            National_id_txtbox.Name = "National_id_txtbox";
            National_id_txtbox.Size = new Size(189, 30);
            National_id_txtbox.TabIndex = 13;
            National_id_txtbox.TextAlign = HorizontalAlignment.Center;
            National_id_txtbox.TextChanged += National_id_txtbox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SeaGreen;
            label7.Location = new Point(293, 274);
            label7.Name = "label7";
            label7.Size = new Size(100, 16);
            label7.TabIndex = 16;
            label7.Text = "Phone Number";
            // 
            // user_txtbox
            // 
            user_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            user_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            user_txtbox.Location = new Point(540, 147);
            user_txtbox.Multiline = true;
            user_txtbox.Name = "user_txtbox";
            user_txtbox.Size = new Size(182, 30);
            user_txtbox.TabIndex = 15;
            user_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaGreen;
            pictureBox1.Image = Properties.Resources.icons8_person_641;
            pictureBox1.Location = new Point(63, 23);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(74, 166);
            button2.Name = "button2";
            button2.Size = new Size(98, 21);
            button2.TabIndex = 18;
            button2.Text = "Select Photo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(413, 424);
            button1.Name = "button1";
            button1.Size = new Size(208, 35);
            button1.TabIndex = 0;
            button1.Text = "Regisiter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 493);
            panel1.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-28, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(315, 300);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location = new Point(30, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SeaGreen;
            label8.Location = new Point(290, 71);
            label8.Name = "label8";
            label8.Size = new Size(103, 32);
            label8.TabIndex = 20;
            label8.Text = "Sign Up";
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button5);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(660, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 493);
            panel2.TabIndex = 24;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaGreen;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.ControlDarkDark;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(112, 3);
            button4.Name = "button4";
            button4.Size = new Size(34, 30);
            button4.TabIndex = 29;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = Properties.Resources.icons8_minus_24;
            button3.Location = new Point(11, 3);
            button3.Name = "button3";
            button3.Size = new Size(34, 30);
            button3.TabIndex = 28;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SeaGreen;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.ControlDarkDark;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(62, 3);
            button5.Name = "button5";
            button5.Size = new Size(34, 30);
            button5.TabIndex = 27;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(304, 402);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(181, 19);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "I Agree Terms and Conditions";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Sign_up_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 493);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(user_txtbox);
            Controls.Add(label6);
            Controls.Add(National_id_txtbox);
            Controls.Add(label5);
            Controls.Add(cpass_txtbox);
            Controls.Add(label4);
            Controls.Add(email_txtbox);
            Controls.Add(label3);
            Controls.Add(password_txtbox);
            Controls.Add(label2);
            Controls.Add(phone_num_txtbox);
            Controls.Add(label1);
            Controls.Add(name_txtbox);
            Controls.Add(button1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sign_up_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign up ";
            Load += Sign_up_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox name_txtbox;
        private Label label2;
        private TextBox phone_num_txtbox;
        private Label label3;
        private TextBox password_txtbox;
        private Label label4;
        private TextBox email_txtbox;
        private Label label5;
        private TextBox cpass_txtbox;
        private Label label6;
        private TextBox National_id_txtbox;
        private Label label7;
        private TextBox user_txtbox;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button button5;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
    }
}