﻿namespace WinFormsApp4
{
    partial class forget_pas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forget_pas));
            email_txtbox = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // email_txtbox
            // 
            email_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            email_txtbox.ForeColor = Color.SeaGreen;
            email_txtbox.Location = new Point(39, 55);
            email_txtbox.Multiline = true;
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Size = new Size(190, 30);
            email_txtbox.TabIndex = 11;
            email_txtbox.TextAlign = HorizontalAlignment.Center;
            email_txtbox.TextChanged += email_txtbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(39, 36);
            label3.Name = "label3";
            label3.Size = new Size(98, 16);
            label3.TabIndex = 10;
            label3.Text = "Enter an Email";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.SeaGreen;
            textBox1.Location = new Point(39, 187);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 30);
            textBox1.TabIndex = 13;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(39, 168);
            label1.Name = "label1";
            label1.Size = new Size(221, 16);
            label1.TabIndex = 12;
            label1.Text = "Enter the code the send by email";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.SeaGreen;
            textBox2.Location = new Point(39, 254);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 30);
            textBox2.TabIndex = 15;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.SeaGreen;
            textBox3.Location = new Point(39, 310);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 30);
            textBox3.TabIndex = 17;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(39, 235);
            label5.Name = "label5";
            label5.Size = new Size(70, 16);
            label5.TabIndex = 18;
            label5.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(39, 291);
            label2.Name = "label2";
            label2.Size = new Size(132, 16);
            label2.TabIndex = 19;
            label2.Text = "Re-Enter Password";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(84, 91);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Send email";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location = new Point(336, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(298, 239);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button8);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(539, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 477);
            panel4.TabIndex = 35;
            // 
            // button6
            // 
            button6.BackColor = Color.SeaGreen;
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = SystemColors.ControlDarkDark;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(137, 3);
            button6.Name = "button6";
            button6.Size = new Size(34, 30);
            button6.TabIndex = 32;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.SeaGreen;
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = Properties.Resources.icons8_minus_24;
            button7.Location = new Point(36, 3);
            button7.Name = "button7";
            button7.Size = new Size(34, 30);
            button7.TabIndex = 31;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.SeaGreen;
            button8.FlatStyle = FlatStyle.Popup;
            button8.ForeColor = SystemColors.ControlDarkDark;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(87, 3);
            button8.Name = "button8";
            button8.Size = new Size(34, 30);
            button8.TabIndex = 30;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // forget_pas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 477);
            Controls.Add(pictureBox2);
            Controls.Add(panel4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(email_txtbox);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "forget_pas";
            Text = "forget_pas";
            Load += forget_pas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email_txtbox;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}