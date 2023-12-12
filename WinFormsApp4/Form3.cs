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

namespace WinFormsApp4
{
    public partial class New_stu_reg : Form
    {
        public New_stu_reg()
        {
            InitializeComponent();
        }

        private void name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void N_id_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Faculty_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Level_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_newstudbtn_Click(object sender, EventArgs e)
        {
            StudentsTable student = new StudentsTable()
            {
                name = name_txtbox.Text,
                student_n_id = N_id_txtbox.Text,
                faculty = Faculty_txtbox.Text,
                level = Convert.ToInt32(Level_txtbox.Text)
            };
            ValidationMethods.AddStudent(student);
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void New_stu_reg_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            string employeeID = program_main_form.E_id;
            program_main_form pp = new program_main_form(employeeID);
            pp.Show();
            this.Close();
        }
    }
}
