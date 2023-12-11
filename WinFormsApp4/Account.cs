using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using funcs;
using WinFormsApp4.data;

namespace WinFormsApp4
{
    public partial class Account : Form
    {
        string employee_n_id;
        string org_image_path;
        data.EmployeeTable emp;
        string source;

        public Account(string employee_n_id)
        {
            InitializeComponent();
            emp = DataBaseMethods.GetEmlpyeeByID(employee_n_id);
            LoadEmployeeData(employee_n_id);
            source = emp.photo_path;
        }

        private void LoadEmployeeData(string employee_n_id) // Show data on the form
        {
            name_txtbox.Text = emp.name;
            user_txtbox.Text = emp.user_name;
            National_id_txtbox.Text = emp.employee_n_id;
            password_txtbox.Text = emp.password;
            cpass_txtbox.Text = emp.password;
            phone_num_txtbox.Text = emp.phone_number;
            email_txtbox.Text = emp.email;
            pictureBox1.ImageLocation = emp.photo_path;
            org_image_path = emp.photo_path;
        }






        private void button7_Click(object sender, EventArgs e) // Save Changes
        {
            // Create an instance of EmployeeTable with data from text boxes

            DialogResult result = MessageBox.Show("Are you sure To Save Changes?", "Save Changes",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // Check if the user clicked OK
            if (result == DialogResult.OK)
            {

                EmployeeTable updateemp = new EmployeeTable
                {
                    employee_n_id = National_id_txtbox.Text,
                    name = name_txtbox.Text,
                    phone_number = phone_num_txtbox.Text,
                    email = email_txtbox.Text,
                    user_name = user_txtbox.Text,
                    photo_path = source,
                    password = password_txtbox.Text
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
                    AppDbContext db = new AppDbContext();


                    if (db.employees.Count((x) => x.user_name == user_txtbox.Text) > 1)
                    {
                        MessageBox.Show("The User Already Exist Try anthor one \" ", "Error"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validate = false;
                    }

                    else if (!ValidationMethods.NationalIdLen(National_id_txtbox.Text))
                    {
                        MessageBox.Show("National Id must be 14 Digits", "Error"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validate = false;
                    }

                    else if (db.employees.Count((x) => x.employee_n_id == National_id_txtbox.Text) > 1)

                    {
                        MessageBox.Show("National ID Already Exist Try anthor one", "Error"
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
                    else if (db.employees.Count((x) => x.email == email_txtbox.Text) > 1)
                    {
                        MessageBox.Show("The Email Already Exist Try anthor one \" ", "Error"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validate = false;
                    }

                    string confirmed_pass = this.cpass_txtbox.Text;
                    if (Validate && ValidationMethods.password(updateemp, confirmed_pass))
                    {


                        if (ValidationMethods.CopyImage(updateemp.photo_path, updateemp.user_name, updateemp))
                        {
                            DataBaseMethods.UpdateEmployeeById(updateemp.employee_n_id, updateemp);
                            MessageBox.Show("Your Account Updated successfully");
                            Application.OpenForms[0].Show();
                            this.Close();
                        }


                    }
                }
            }




            // Call the UpdateEmployeeById function



        }

        private void button5_Click(object sender, EventArgs e) // Browse Image
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

                    // Perform additional checks if needed before setting the image
                    if (ValidationMethods.IsImageFile(selectedFilePath))
                    {
                        // Load the image to the pictureBox
                        pictureBox1.ImageLocation = selectedFilePath;
                        source = selectedFilePath;
                        Program.Log(selectedFilePath);
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

            //try
            //{
            //    if (File.Exists(org_image_path))
            //    {
            //        File.Delete(org_image_path);
            //    }
            //}
            //catch (Exception)
            //{

            //}

            //try
            //{
            //    openFileDialog1.Title = "Select your personal photo";
            //    openFileDialog1.ShowDialog();
            //    source = openFileDialog1.FileName;
            //    pictureBox1.ImageLocation = source;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void email_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Delete Your Acount", "Delete Acount",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // Check if the user clicked OK
            if (result == DialogResult.OK)
            {
                DataBaseMethods.DeleteEmployeeById(National_id_txtbox.Text);
                // Show the first form
                Login_Page login_Page = new Login_Page();
                login_Page.ShowDialog();
                this.Close();


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Discard Changes", "Discard Changes",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // Check if the user clicked OK
            if (result == DialogResult.OK)
            {
                // Show the first form
                if (Application.OpenForms.Count > 0)
                    Application.OpenForms[0].Show();
                // Close the current form
                this.Close();


            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                password_txtbox.UseSystemPasswordChar = false;
            }
            else { password_txtbox.UseSystemPasswordChar = true ;}
        }
    }
}
// Archieve
//private void button1_Click(object sender, EventArgs e) // Save Changes & Update Empoyee Data
//{
//    // Create an instance of EmployeeTable with data from text boxes
//    EmployeeTable updatedEmployee = new EmployeeTable
//    {
//        employee_n_id = National_id_txtbox.Text,
//        name = name_txtbox.Text,
//        phone_number = phone_num_txtbox.Text,
//        email = email_txtbox.Text,
//        user_name = user_txtbox.Text,
//        photo_path = source,
//        password = password_txtbox.Text
//    };

//    // Call the UpdateEmployeeById function
//    DataBaseMethods.UpdateEmployeeById(updatedEmployee.employee_n_id, updatedEmployee);
//}

//private void button3_Click(object sender, EventArgs e) // Browse Image
//{

//    try
//    {
//        if (File.Exists(org_image_path))
//        {
//            File.Delete(org_image_path);
//        }
//    }
//    catch (Exception)
//    {

//    }
//    try
//    {
//        openFileDialog1.Title = "Select your personal photo";
//        openFileDialog1.ShowDialog();
//        source = openFileDialog1.FileName;
//        pictureBox1.ImageLocation = source;
//    }
//    catch (Exception)
//    {
//        MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}



/*
 *  Note: Maximize Box changed from True To Flase
 * 
 * 
 */
