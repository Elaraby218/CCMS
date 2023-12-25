using funcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4.data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class Print : DraggablePanel
    {
        public Print()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Print_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            AppDbContext db = AppDbContext.Instance;
            int price= int.Parse(tt_cost.Text);
            var res = db.in_students.Where(st => st.student_n_id == textBox1.Text).FirstOrDefault();
            if (res != null)
            {
                res.paper_printed += price;
                db.in_students.Update(res);
                db.SaveChanges();
            }

            else
            {
                InStudentsTable st = new InStudentsTable()
                {
                    student_n_id = "1",
                    in_time = DateTime.Now.ToString("HH:mm"),
                    paper_printed = price, 
                };


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.Count > 0)
                Application.OpenForms[0].Show();
            this.Close();
        }

        private void Num_pg_tb_TextChanged(object sender, EventArgs e)
        {
            // Perform the calculation when the text in TextBox1 changes
            if (int.TryParse(Num_pg_tb.Text, out int inputValue))
            {

                double result = inputValue * 1.5;
                tt_cost.Text = result.ToString();
            }
            else
            {
                
                tt_cost.Text = "Invalid input";
            }
        }
    }
}
