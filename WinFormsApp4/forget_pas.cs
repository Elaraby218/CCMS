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

namespace WinFormsApp4
{
    public partial class forget_pas : Form
    {
        public forget_pas()
        {
            InitializeComponent();
        }
        string code;

        private void forget_pas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string emai = email_txtbox.Text;
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
                    SmtpClient smm = new SmtpClient();
                    mailMessage.From = new MailAddress("sherifelglaly@gmail.com");
                    mailMessage.To.Add(new MailAddress(emai));
                    mailMessage.Subject = "Change Password";
                    mailMessage.Body = "the code is \n" + code + "\n Thanks";
                    smm.Port = 587;
                    smm.Host = "smtp.gmail.com";
                    smm.EnableSsl = true;
                    smm.UseDefaultCredentials = false;
                    smm.Credentials = new NetworkCredential(emai, "set Pasword");
                    smm.Send(mailMessage);
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
            if (textBox1.Text == code)
            {
                MessageBox.Show("Enter the new Password");
            }
            else
                MessageBox.Show("Not correct code");

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
    }
}
