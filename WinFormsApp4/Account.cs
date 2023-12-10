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
            phone_num_txtbox.Text = emp.phone_number;
            email_txtbox.Text = emp.email;
            pictureBox1.ImageLocation = emp.photo_path;
            org_image_path = emp.photo_path;
        }




        private void button2_Click(object sender, EventArgs e) //  Delete Account
        {
            DataBaseMethods.DeleteEmployeeById(employee_n_id); // Deleting the account from the data
        }

        private void button7_Click(object sender, EventArgs e) // Save Changes
        {
            // Create an instance of EmployeeTable with data from text boxes

            ValidationMethods.CopyImage(source, emp.user_name, emp);
            EmployeeTable updatedEmployee = new EmployeeTable
            {
                employee_n_id = National_id_txtbox.Text,
                name = name_txtbox.Text,
                phone_number = phone_num_txtbox.Text,
                email = email_txtbox.Text,
                user_name = user_txtbox.Text,
                photo_path = source,
                password = password_txtbox.Text
            };

            // Call the UpdateEmployeeById function
            DataBaseMethods.UpdateEmployeeById(updatedEmployee.employee_n_id, updatedEmployee);

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
