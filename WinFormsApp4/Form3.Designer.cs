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
            name_txtbox = new TextBox();
            Faculty_txtbox = new TextBox();
            N_id_txtbox = new TextBox();
            Level_txtbox = new TextBox();
            name_lbl = new Label();
            Level_lbl = new Label();
            N_id_lbl = new Label();
            Faculty_lbl = new Label();
            add_new_stu_reg_btn = new Button();
            SuspendLayout();
            // 
            // name_txtbox
            // 
            name_txtbox.Location = new Point(153, 95);
            name_txtbox.Multiline = true;
            name_txtbox.Name = "name_txtbox";
            name_txtbox.Size = new Size(235, 42);
            name_txtbox.TabIndex = 0;
            name_txtbox.TextChanged += name_txtbox_TextChanged;
            // 
            // Faculty_txtbox
            // 
            Faculty_txtbox.Location = new Point(519, 95);
            Faculty_txtbox.Multiline = true;
            Faculty_txtbox.Name = "Faculty_txtbox";
            Faculty_txtbox.Size = new Size(235, 42);
            Faculty_txtbox.TabIndex = 1;
            Faculty_txtbox.TextChanged += Faculty_txtbox_TextChanged;
            // 
            // N_id_txtbox
            // 
            N_id_txtbox.Location = new Point(153, 200);
            N_id_txtbox.Multiline = true;
            N_id_txtbox.Name = "N_id_txtbox";
            N_id_txtbox.Size = new Size(235, 42);
            N_id_txtbox.TabIndex = 2;
            N_id_txtbox.TextChanged += N_id_txtbox_TextChanged;
            // 
            // Level_txtbox
            // 
            Level_txtbox.Location = new Point(519, 200);
            Level_txtbox.Multiline = true;
            Level_txtbox.Name = "Level_txtbox";
            Level_txtbox.Size = new Size(235, 42);
            Level_txtbox.TabIndex = 3;
            Level_txtbox.TextChanged += Level_txtbox_TextChanged;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Location = new Point(94, 111);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(38, 15);
            name_lbl.TabIndex = 4;
            name_lbl.Text = "label1";
            // 
            // Level_lbl
            // 
            Level_lbl.AutoSize = true;
            Level_lbl.Location = new Point(466, 217);
            Level_lbl.Name = "Level_lbl";
            Level_lbl.Size = new Size(38, 15);
            Level_lbl.TabIndex = 5;
            Level_lbl.Text = "label2";
            // 
            // N_id_lbl
            // 
            N_id_lbl.AutoSize = true;
            N_id_lbl.Location = new Point(94, 217);
            N_id_lbl.Name = "N_id_lbl";
            N_id_lbl.Size = new Size(38, 15);
            N_id_lbl.TabIndex = 6;
            N_id_lbl.Text = "label3";
            // 
            // Faculty_lbl
            // 
            Faculty_lbl.AutoSize = true;
            Faculty_lbl.Location = new Point(466, 111);
            Faculty_lbl.Name = "Faculty_lbl";
            Faculty_lbl.Size = new Size(38, 15);
            Faculty_lbl.TabIndex = 7;
            Faculty_lbl.Text = "label4";
            // 
            // add_new_stu_reg_btn
            // 
            add_new_stu_reg_btn.Location = new Point(340, 351);
            add_new_stu_reg_btn.Name = "add_new_stu_reg_btn";
            add_new_stu_reg_btn.Size = new Size(188, 40);
            add_new_stu_reg_btn.TabIndex = 8;
            add_new_stu_reg_btn.Text = "button1";
            add_new_stu_reg_btn.UseVisualStyleBackColor = true;
            add_new_stu_reg_btn.Click += add_new_stu_reg_btn_Click;
            // 
            // New_stu_reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add_new_stu_reg_btn);
            Controls.Add(Faculty_lbl);
            Controls.Add(N_id_lbl);
            Controls.Add(Level_lbl);
            Controls.Add(name_lbl);
            Controls.Add(Level_txtbox);
            Controls.Add(N_id_txtbox);
            Controls.Add(Faculty_txtbox);
            Controls.Add(name_txtbox);
            Name = "New_stu_reg";
            Text = "reg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name_txtbox;
        private TextBox Faculty_txtbox;
        private TextBox N_id_txtbox;
        private TextBox Level_txtbox;
        private Label name_lbl;
        private Label Level_lbl;
        private Label N_id_lbl;
        private Label Faculty_lbl;
        private Button add_new_stu_reg_btn;
    }
}