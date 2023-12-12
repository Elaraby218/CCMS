namespace WinFormsApp4
{
    partial class New_stu_reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_stu_reg));
            name_txtbox = new TextBox();
            Faculty_txtbox = new TextBox();
            N_id_txtbox = new TextBox();
            Level_txtbox = new TextBox();
            name_lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Reg_newstudbtn = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // name_txtbox
            // 
            name_txtbox.Location = new Point(70, 41);
            name_txtbox.Multiline = true;
            name_txtbox.Name = "name_txtbox";
            name_txtbox.Size = new Size(235, 42);
            name_txtbox.TabIndex = 0;
            name_txtbox.TextChanged += name_txtbox_TextChanged;
            // 
            // Faculty_txtbox
            // 
            Faculty_txtbox.Location = new Point(70, 180);
            Faculty_txtbox.Multiline = true;
            Faculty_txtbox.Name = "Faculty_txtbox";
            Faculty_txtbox.Size = new Size(235, 42);
            Faculty_txtbox.TabIndex = 1;
            Faculty_txtbox.TextChanged += Faculty_txtbox_TextChanged;
            // 
            // N_id_txtbox
            // 
            N_id_txtbox.Location = new Point(70, 108);
            N_id_txtbox.Multiline = true;
            N_id_txtbox.Name = "N_id_txtbox";
            N_id_txtbox.Size = new Size(235, 42);
            N_id_txtbox.TabIndex = 2;
            N_id_txtbox.TextChanged += N_id_txtbox_TextChanged;
            // 
            // Level_txtbox
            // 
            Level_txtbox.Location = new Point(70, 255);
            Level_txtbox.Multiline = true;
            Level_txtbox.Name = "Level_txtbox";
            Level_txtbox.Size = new Size(235, 42);
            Level_txtbox.TabIndex = 3;
            Level_txtbox.TextChanged += Level_txtbox_TextChanged;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.BackColor = Color.Transparent;
            name_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            name_lbl.ForeColor = Color.SeaGreen;
            name_lbl.Location = new Point(70, 22);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(51, 20);
            name_lbl.TabIndex = 4;
            name_lbl.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(70, 157);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 9;
            label1.Text = "Faculty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(70, 91);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 10;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(70, 232);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 11;
            label3.Text = "Level";
            // 
            // Reg_newstudbtn
            // 
            Reg_newstudbtn.BackColor = Color.SeaGreen;
            Reg_newstudbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Reg_newstudbtn.ForeColor = SystemColors.ButtonHighlight;
            Reg_newstudbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Reg_newstudbtn.Location = new Point(115, 321);
            Reg_newstudbtn.Name = "Reg_newstudbtn";
            Reg_newstudbtn.Size = new Size(155, 36);
            Reg_newstudbtn.TabIndex = 22;
            Reg_newstudbtn.Text = "New Student";
            Reg_newstudbtn.UseVisualStyleBackColor = false;
            Reg_newstudbtn.Click += Reg_newstudbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location = new Point(0, 244);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 196);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(434, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 440);
            panel1.TabIndex = 35;
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
            button5.Click += button5_Click_1;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.DarkSeaGreen;
            btn_back.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(12, 392);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 36);
            btn_back.TabIndex = 36;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // New_stu_reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 440);
            Controls.Add(btn_back);
            Controls.Add(Reg_newstudbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name_lbl);
            Controls.Add(Level_txtbox);
            Controls.Add(N_id_txtbox);
            Controls.Add(Faculty_txtbox);
            Controls.Add(name_txtbox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "New_stu_reg";
            Text = "reg";
            Load += New_stu_reg_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name_txtbox;
        private TextBox Faculty_txtbox;
        private TextBox N_id_txtbox;
        private TextBox Level_txtbox;
        private Label name_lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Reg_newstudbtn;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button btn_back;
    }
}