using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.Windows.Forms;
using WinFormsApp4.data;
using System.ComponentModel;
using funcs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class Sign_up_form : Form
    {


        string imageSource = "";
        string imageDestinationFolderPath = Environment.CurrentDirectory + "\\images\\";

        public Sign_up_form()
        {
            InitializeComponent();
            //  MessageBox.Show(Environment.CurrentDirectory);
            // default photo on pt3
            pictureBox1.ImageLocation = imageSource;
            password_txtbox.UseSystemPasswordChar = true;
            cpass_txtbox.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e) // Register
        {

            EmployeeTable emp = new EmployeeTable
            {
                name = this.name_txtbox.Text,
                employee_n_id = this.National_id_txtbox.Text,
                password = this.password_txtbox.Text,
                email = this.email_txtbox.Text,
                user_name = this.user_txtbox.Text,
                phone_number = this.phone_num_txtbox.Text,
                photo_path = imageSource
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
                if (ValidationMethods.UserName(user_txtbox.Text))
                {
                    MessageBox.Show("User name in use, please select another user name", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Validate = false;
                }

                else if (ValidationMethods.EmpNationalId(National_id_txtbox.Text))
                {
                    MessageBox.Show("Wrong National ID", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Validate = false;
                }

                else if (!ValidationMethods.NationalIdLen(National_id_txtbox.Text))
                {
                    MessageBox.Show("National Id must be 14 Digits", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Validate = false;
                }

                else if (!ValidationMethods.PhoneNumber(phone_num_txtbox.Text))
                {
                    MessageBox.Show("Phone number must be 11 digits ", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Validate = false;
                }

                else if (!ValidationMethods.Email(email_txtbox.Text))
                {
                    MessageBox.Show("The Email must be in form \"example@example.com\" ", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Validate = false;
                }
                else if (db.employees.Count((x) => x.email == email_txtbox.Text) >= 1)
                {
                    MessageBox.Show("The Email Already Exist Try anthor one \" ", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Validate = false;
                }
                else if (!checkBox1.Checked)
                {
                    MessageBox.Show("Click on \"Agree Terms and Conditions\"  ", "Error"
                  , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Validate = false;
                }





                string confirmed_pass = this.cpass_txtbox.Text;
                if (Validate && ValidationMethods.password(emp, confirmed_pass))
                {

                    string newImagePath = ValidationMethods.CreateEmployeeImageFilePath(imageDestinationFolderPath, emp);
                    ValidationMethods.CopyImage(imageSource, newImagePath);


                    //if (ValidationMethods.CopyImage(emp.photo_path, emp.user_name, emp))
                    //{
                        DataBaseMethods.AddEmployee(emp);
                        MessageBox.Show("Your Account Created successfully");
                        Application.OpenForms[0].Show();
                        this.Close();
                    //}



                }
            }


        }

        private string SelectImageFile()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Select your personal photo";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Perform additional checks if needed before returning the path
                    if (ValidationMethods.IsImageFile(selectedFilePath))
                    {
                        return selectedFilePath;
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null; // Return null if file selection failed or was invalid
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string selectedFilePath = SelectImageFile(); // This opens the dialog to get the image path

            if (selectedFilePath != null)
            {
                // Load the image to the pictureBox
                pictureBox1.ImageLocation = selectedFilePath;
                imageSource = selectedFilePath;
                //Program.Log(selectedFilePath);
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBox2.Checked) { password_txtbox.UseSystemPasswordChar = true;
                cpass_txtbox.UseSystemPasswordChar = true;
            }
            else {
                password_txtbox.UseSystemPasswordChar = false;
                cpass_txtbox.UseSystemPasswordChar = false;
            }
        }



        // Empty Functions
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void National_id_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
