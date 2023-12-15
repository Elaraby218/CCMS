namespace WinFormsApp4
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
            email_txtbox = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label8 = new Label();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // email_txtbox
            // 
            email_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            email_txtbox.ForeColor = Color.SeaGreen;
            email_txtbox.Location = new Point(119, 128);
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Size = new Size(221, 23);
            email_txtbox.TabIndex = 11;
            email_txtbox.TextChanged += email_txtbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(119, 109);
            label3.Name = "label3";
            label3.Size = new Size(113, 16);
            label3.TabIndex = 10;
            label3.Text = "Enter Your Email";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.SeaGreen;
            textBox2.Location = new Point(119, 260);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.SeaGreen;
            textBox3.Location = new Point(119, 323);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 23);
            textBox3.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(119, 241);
            label5.Name = "label5";
            label5.Size = new Size(101, 16);
            label5.TabIndex = 18;
            label5.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(119, 304);
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
            button1.Location = new Point(119, 164);
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
            pictureBox2.Location = new Point(346, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(272, 239);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(119, 352);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 36;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(22, 128);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 38;
            label4.Text = "Step 1";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SeaGreen;
            label8.Location = new Point(22, 292);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 41;
            label8.Text = "Step 2";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(119, 284);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(107, 17);
            checkBox2.TabIndex = 43;
            checkBox2.Text = "Show Password";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // forget_pas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 432);
            Controls.Add(checkBox2);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(email_txtbox);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "forget_pas";
            Text = "forget_pas";
            Load += forget_pas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email_txtbox;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label8;
        private CheckBox checkBox2;
    }
}