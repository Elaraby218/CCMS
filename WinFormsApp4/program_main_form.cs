using funcs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp4.data;
using System.Drawing.Text;

namespace WinFormsApp4
{


    // branch
    public partial class program_main_form : Form
    {


        string txt = "null";
        string cur_user_name;

        public program_main_form(string employee_n_id)
        {
            InitializeComponent();
            Reg_newstudbtn.Hide();
            this.employee_n_id = employee_n_id;
            name_label_text = db.employees
                .Where((x) => x.employee_n_id == employee_n_id).FirstOrDefault().name;
            cur_user_name = name_label_text = db.employees
                .Where((x) => x.employee_n_id == employee_n_id).FirstOrDefault().user_name;
            txt = name_label_text;
            textBox1.Text = txt;
            string photo_path_to_show = db.employees
                .Where((x) => x.employee_n_id == employee_n_id).FirstOrDefault().photo_path;
            pictureBox1.ImageLocation = photo_path_to_show;
            reload();
        }

        private void Log_out_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure ?", "LOG OUT",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void program_main_form_Load(object sender, EventArgs e)
        {

        }

        private void History_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOT IMPLEMENTED YET", "Sorry",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            throw new NotImplementedException();
        }

        private void FindSTU_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOT IMPLEMENTED YET", "Sorry",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StudentOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOT IMPLEMENTED YET", "Sorry",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudNational_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

        }

        private void AddStudBtn(object sender, EventArgs e)
        {
            if (ValidationMethods.StudentNationalId(StudNational_txtbox.Text))
            {
                DataBaseMethods.AddToInStudent(StudNational_txtbox.Text);
            }
            else
            {
                MessageBox.Show("No such student found, please add new student", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Reg_newstudbtn.Show();
                // add new student button show 
            }
            reload();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reg_newstudbtn_Click(object sender, EventArgs e)
        {
            New_stu_reg frm = new New_stu_reg();
            frm.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataBaseMethods.StudentOut(StudNational_txtbox.Text, this.employee_n_id);
            reload();

        }
        private void reload()
        {
            this.dataGridView2.Rows.Clear();
            // dataGridView2.Rows.CollectionChanged();
            var InView = DataBaseMethods.getInView();
            foreach (var element in InView)
            {
                this.dataGridView2.Rows.Add(element[0], element[1], element[2], element[3], element[4]);
            }

        }
    }
}

