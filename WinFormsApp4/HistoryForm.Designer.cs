namespace WinFormsApp4
{
    partial class HistoryForm
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
            components = new System.ComponentModel.Container();
            historyTableBindingSource = new BindingSource(components);
            Search_btn = new Button();
            Search_txtbox = new TextBox();
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            panel2 = new Panel();
            Histroty_dgridview = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Clear_filter_btn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)historyTableBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Histroty_dgridview).BeginInit();
            SuspendLayout();
            // 
            // historyTableBindingSource
            // 
            historyTableBindingSource.DataSource = typeof(data.HistoryTable);
            // 
            // Search_btn
            // 
            Search_btn.BackColor = Color.SeaGreen;
            Search_btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Search_btn.ForeColor = SystemColors.ButtonHighlight;
            Search_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Search_btn.Location = new Point(227, 585);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(155, 41);
            Search_btn.TabIndex = 28;
            Search_btn.Text = "Search";
            Search_btn.UseVisualStyleBackColor = false;
            Search_btn.Click += Back_btn_Click;
            // 
            // Search_txtbox
            // 
            Search_txtbox.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Search_txtbox.Location = new Point(405, 585);
            Search_txtbox.Name = "Search_txtbox";
            Search_txtbox.Size = new Size(365, 32);
            Search_txtbox.TabIndex = 29;
            Search_txtbox.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(Search_txtbox, "Insert National id to search for");
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Location = new Point(1082, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 608);
            panel1.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Location = new Point(-12, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(22, 608);
            panel2.TabIndex = 31;
            // 
            // Histroty_dgridview
            // 
            Histroty_dgridview.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            Histroty_dgridview.Location = new Point(16, 43);
            Histroty_dgridview.Name = "Histroty_dgridview";
            Histroty_dgridview.Size = new Size(1060, 522);
            Histroty_dgridview.TabIndex = 0;
            Histroty_dgridview.CellContentClick += Histroty_dgridview_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Employee";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Student ID";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Time in";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Time out";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Date";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Cost";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Papers";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Clear_filter_btn
            // 
            Clear_filter_btn.BackColor = Color.SeaGreen;
            Clear_filter_btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Clear_filter_btn.ForeColor = SystemColors.ButtonHighlight;
            Clear_filter_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Clear_filter_btn.Location = new Point(788, 585);
            Clear_filter_btn.Name = "Clear_filter_btn";
            Clear_filter_btn.Size = new Size(154, 41);
            Clear_filter_btn.TabIndex = 32;
            Clear_filter_btn.Text = "Reset";
            Clear_filter_btn.UseVisualStyleBackColor = false;
            Clear_filter_btn.Click += Clear_filter_btn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(505, 626);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 33;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 652);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Clear_filter_btn);
            Controls.Add(Histroty_dgridview);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Search_txtbox);
            Controls.Add(Search_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HistoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HirtoryForm";
            Load += HirtoryForm_Load;
            Controls.SetChildIndex(Search_btn, 0);
            Controls.SetChildIndex(Search_txtbox, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(Histroty_dgridview, 0);
            Controls.SetChildIndex(Clear_filter_btn, 0);
            Controls.SetChildIndex(flowLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)historyTableBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)Histroty_dgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Search_btn;
        private TextBox Search_txtbox;
        private ToolTip toolTip1;
        private Panel panel1;
        private Panel panel2;
        private BindingSource historyTableBindingSource;
        private DataGridView Histroty_dgridview;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button Clear_filter_btn;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}