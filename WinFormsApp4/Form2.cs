using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.Windows.Forms;
using WinFormsApp4.data;
using System.ComponentModel;
using funcs;

namespace WinFormsApp4
{
    public partial class Sign_up_form : Form
    {


        string source = "J:\\c#\\WinFormsApp4\\WinFormsApp4\\bin\\Debug\\net6.0-windows\\images\\userDEF.png";
        public Sign_up_form()
        {
            InitializeComponent();
            //  MessageBox.Show(Environment.CurrentDirectory);
            // default photo on pt3
            pictureBox1.ImageLocation = source; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EmployeeTable emp = new EmployeeTable
            {
                name = this.name_txtbox.Text,
                employee_n_id = this.National_id_txtbox.Text,
                password = this.password_txtbox.Text,
                email = this.email_txtbox.Text,
                user_name = this.user_txtbox.Text,
                phone_number = this.phone_num_txtbox.Text,
                photo_path = source
            };
            List<string> empty_ent = ValidationMethods.Employee(emp);

            if (empty_ent.Count > 0)
            {
                MessageBox.Show($"These Fields can not be empty\n{string.Join("\n", empty_ent)}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool Validate = true; 

                if(ValidationMethods.NationalId(National_id_txtbox.Text))
                {
                    MessageBox.Show("Wrong National ID", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Validate = false;
                }

                if (!ValidationMethods.NationalIdLen(National_id_txtbox.Text))
                {
                    MessageBox.Show("National Id must be 14 Digits", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Validate = false;
                }

                if (!ValidationMethods.PhoneNumber(phone_num_txtbox.Text))
                {
                    MessageBox.Show("Phone number must be 11 digits ", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Validate = false;
                }

                if (!ValidationMethods.Email(email_txtbox.Text))
                {
                    MessageBox.Show("The Email must be in form \"example@example.com\" " , "Error" 
                        , MessageBoxButtons.OK , MessageBoxIcon.Error);
                    Validate = false; 
                }

                if (ValidationMethods.UserName(user_txtbox.Text))
                {
                    MessageBox.Show("User name in use, please select another user name", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Validate = false;
                }



                string confirmed_pass = this.cpass_txtbox.Text;
                if (Validate && ValidationMethods.password(emp, confirmed_pass) )
                {
                    DataBaseMethods.AddEmployee(emp);
                    Application.OpenForms[0].Show();
                    this.Close();
                }
            }


        }

        private void Sign_up_form_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            try
            {
                openFileDialog1.Title = "Select your personal photo";
                openFileDialog1.ShowDialog();
                source = openFileDialog1.FileName;
                pictureBox1.ImageLocation = source;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           // MessageBox.Show(imagelocation);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
