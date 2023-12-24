namespace WinFormsApp4
{
    partial class Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            pictureBox3=new PictureBox();
            panel1=new Panel();
            label2=new Label();
            name_lbl=new Label();
            N_id_txtbox=new TextBox();
            name_txtbox=new TextBox();
            label1=new Label();
            label3=new Label();
            textBox1=new TextBox();
            button1=new Button();
            button2=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image=(Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location=new Point(-7, 106);
            pictureBox3.Margin=new Padding(3, 4, 3, 4);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(317, 362);
            pictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex=21;
            pictureBox3.TabStop=false;
            // 
            // panel1
            // 
            panel1.AutoSize=true;
            panel1.BackColor=Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock=DockStyle.Left;
            panel1.Location=new Point(0, 0);
            panel1.Margin=new Padding(3, 4, 3, 4);
            panel1.Name="panel1";
            panel1.Size=new Size(313, 512);
            panel1.TabIndex=42;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.Transparent;
            label2.Font=new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor=Color.SeaGreen;
            label2.Location=new Point(381, 321);
            label2.Name="label2";
            label2.Size=new Size(116, 30);
            label2.TabIndex=46;
            label2.Text="Total Cost";
            // 
            // name_lbl
            // 
            name_lbl.AutoSize=true;
            name_lbl.BackColor=Color.Transparent;
            name_lbl.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            name_lbl.ForeColor=Color.SeaGreen;
            name_lbl.Location=new Point(381, 261);
            name_lbl.Name="name_lbl";
            name_lbl.Size=new Size(169, 25);
            name_lbl.TabIndex=45;
            name_lbl.Text="Number Of Pages";
            // 
            // N_id_txtbox
            // 
            N_id_txtbox.Location=new Point(381, 357);
            N_id_txtbox.Margin=new Padding(3, 4, 3, 4);
            N_id_txtbox.Name="N_id_txtbox";
            N_id_txtbox.ReadOnly=true;
            N_id_txtbox.Size=new Size(178, 27);
            N_id_txtbox.TabIndex=44;
            // 
            // name_txtbox
            // 
            name_txtbox.Location=new Point(381, 290);
            name_txtbox.Margin=new Padding(3, 4, 3, 4);
            name_txtbox.Name="name_txtbox";
            name_txtbox.Size=new Size(177, 27);
            name_txtbox.TabIndex=43;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.Transparent;
            label1.Font=new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.SeaGreen;
            label1.Location=new Point(400, 70);
            label1.Name="label1";
            label1.Size=new Size(126, 54);
            label1.TabIndex=48;
            label1.Text="Print ";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.BackColor=Color.Transparent;
            label3.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor=Color.SeaGreen;
            label3.Location=new Point(381, 199);
            label3.Name="label3";
            label3.Size=new Size(108, 25);
            label3.TabIndex=49;
            label3.Text="Student ID";
            label3.Click+=label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(382, 228);
            textBox1.Margin=new Padding(3, 4, 3, 4);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(177, 27);
            textBox1.TabIndex=50;
            // 
            // button1
            // 
            button1.BackColor=Color.SeaGreen;
            button1.Font=new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor=SystemColors.ButtonHighlight;
            button1.ImageAlign=ContentAlignment.MiddleLeft;
            button1.Location=new Point(381, 423);
            button1.Margin=new Padding(3, 4, 3, 4);
            button1.Name="button1";
            button1.Size=new Size(89, 48);
            button1.TabIndex=51;
            button1.Text="Exit";
            button1.UseVisualStyleBackColor=false;
            // 
            // button2
            // 
            button2.BackColor=Color.SeaGreen;
            button2.Font=new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor=SystemColors.ButtonHighlight;
            button2.ImageAlign=ContentAlignment.MiddleLeft;
            button2.Location=new Point(469, 423);
            button2.Margin=new Padding(3, 4, 3, 4);
            button2.Name="button2";
            button2.Size=new Size(89, 48);
            button2.TabIndex=52;
            button2.Text="Print";
            button2.UseVisualStyleBackColor=false;
            // 
            // Print
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSize=true;
            ClientSize=new Size(642, 512);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(name_lbl);
            Controls.Add(N_id_txtbox);
            Controls.Add(name_txtbox);
            Controls.Add(panel1);
            FormBorderStyle=FormBorderStyle.None;
            Name="Print";
            Text="Print";
            Load+=Print_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(name_txtbox, 0);
            Controls.SetChildIndex(N_id_txtbox, 0);
            Controls.SetChildIndex(name_lbl, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button2, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label2;
        private Label name_lbl;
        private TextBox N_id_txtbox;
        private TextBox name_txtbox;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}