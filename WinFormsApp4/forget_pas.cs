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
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using funcs;
using System.Web;
namespace WinFormsApp4
{
    public partial class forget_pas : DraggablePanel
    {

        public forget_pas()
        {

            //new DraggablePanel(this);
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;

        }
        string code;
        bool flag = false;
        string emai;

        private void forget_pas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            emai = email_txtbox.Text;
            if (!string.IsNullOrWhiteSpace(emai))
            {
                AppDbContext db = AppDbContext.Instance;
                var emp = db.employees.
                   Where(a => a.email == emai).FirstOrDefault();
                if (emp != null)
                {
                    Random random = new Random();
                    code = random.Next(1000, 10000).ToString();

                    MailMessage mailMessage = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    mailMessage.Subject = "Authentication Code for Password Change - CCMS";
                    mailMessage.From = new MailAddress(emai);
                    mailMessage.To.Add(new MailAddress(emai));
                    mailMessage.Body = "The code is\n" + code + "\nThanks";
                    mailMessage.Body = $"Dear {emp.name},\n\n" +
                           $"We hope this email finds you well. Your request to change the password for your account on the CCMS (Customer Care Management System) app has been received.\n\n" +
                           $"To proceed with the password change, please use the following authentication code:\n\n" +
                           $"Authentication Code: {code}\n\n" +
                           $"Please enter this code within the CCMS app to verify your identity and initiate the password change process.\n\n" +
                           $"If you did not make this request, or if you have any concerns regarding your account security, please contact our support team immediately at winformapp010@gmail.com.\n\n" +
                           $"Thank you for choosing CCMS. We are committed to ensuring the security of your account.\n\n" +
                           $"Best regards,\n" +
                           $"CCMS \n" +
                           $"01026386402";

                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;

                    // Use an application-specific password or a secure method to handle credentials
                    string yourGmailAddress = "winformapp010@gmail.com";
                    string yourAppSpecificPassword = "qdsqwsnazpxajhes";

                    smtp.Credentials = new NetworkCredential(yourGmailAddress, yourAppSpecificPassword);

                    try
                    {
                        smtp.Send(mailMessage);

                        MessageBox.Show("Email sent successfully! \n Check Your Email Inbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error sending email Check yout internt connection: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                }
                else
                {
                    MessageBox.Show("Email Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please Enter an Email");
            }
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void email_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                string pass = textBox2.Text, conf_pass = textBox3.Text;
                if (!(string.IsNullOrEmpty(pass) && string.IsNullOrEmpty(conf_pass)))
                {
                    AppDbContext db = AppDbContext.Instance;
                    var emp = db.employees.
                       Where(a => a.email == emai).FirstOrDefault();
                    if (pass == conf_pass)
                    {
                        emp.password = pass;
                        db.Update(emp);
                        db.SaveChanges();
                        MessageBox.Show("Your Password Changed");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please check that password is the same as comfirmed passwoard"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox2.Text = "";
                        textBox3.Text = "";
                    }
                }
                else { MessageBox.Show("Empty Password"); }
            }
            else { MessageBox.Show("Enter the Authentication Code"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string co = textBox1.Text;
            if (co== code)
            {
                MessageBox.Show("The code is Correct \nEnter the new Password");
                flag = true;
            }
            else
            {
                MessageBox.Show("Not correct code");

                flag = false;

            }
        }
    }
}

