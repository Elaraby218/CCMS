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

        private void add_new_stu_reg_btn_Click(object sender, EventArgs e)
        {
            StudentsTable student = new StudentsTable() {
                name = name_txtbox.Text,
                student_n_id = N_id_txtbox.Text,
                faculty = Faculty_txtbox.Text,
                level = Convert.ToInt32(Level_txtbox.Text)
            };
            ValidationMethods.AddStudent(student);
            this.Close();
        }
    }
}
