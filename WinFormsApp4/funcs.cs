using WinFormsApp4;
using System.Text.RegularExpressions;
using WinFormsApp4.data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics.Eventing.Reader;

namespace funcs
{
    // this is mohamed ramadan elaryb branch dont touch it 
    
    public static class ValidationMethods
    {

       
        public static List<string> Employee(EmployeeTable emp)
        {
            List<string> empty_ent = new List<string>();

            if (string.IsNullOrEmpty(emp.name) && string.IsNullOrWhiteSpace(emp.name))
                empty_ent.Add("Name");

            if (string.IsNullOrEmpty(emp.employee_n_id) && string.IsNullOrWhiteSpace(emp.employee_n_id))
                empty_ent.Add("National id");

            if (string.IsNullOrEmpty(emp.phone_number) && string.IsNullOrWhiteSpace(emp.phone_number))
                empty_ent.Add("Phone Number");

            if (string.IsNullOrEmpty(emp.email) && string.IsNullOrWhiteSpace(emp.email))
                empty_ent.Add("Email");
            if (string.IsNullOrEmpty(emp.user_name) && string.IsNullOrWhiteSpace(emp.user_name))
                empty_ent.Add("User Name");
            if (string.IsNullOrEmpty(emp.password) && string.IsNullOrWhiteSpace(emp.password))
                empty_ent.Add("Password");
            return empty_ent;
        }
        public static bool password(EmployeeTable emp, string confirmed_pass)
        {
            if (emp.password == confirmed_pass)
            {               
                //MessageBox.Show("Done", "Registration complete", MessageBoxButtons.OK,
                //MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Regeister not complete, please check that password is the same as comfirmed passwoard"
                , "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        public static bool Employee_val(string user_name, string password)
        {
            if (string.IsNullOrWhiteSpace(user_name) &&
                      string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please insert user name and password");
                return false;
            }
            else if (DataBaseMethods.Is_Employee(user_name, password))
            {
                MessageBox.Show("Welcome", DataBaseMethods.getEmpName(user_name),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        public static bool CopyImage(string source , string usernow , EmployeeTable emp)
        {
            if (!string.IsNullOrWhiteSpace(source))
            {
                  string dest = Environment.CurrentDirectory + "\\images" +
                               $"\\{usernow}.jpg";
                File.Copy(source, dest);
                emp.photo_path = dest;
       
                return true;
               
            } else { 
                
                MessageBox.Show("Select a photo");
                return false;
            }
        }
        public static bool Email(string email)
        {
            string expectedEmailFormat = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return (Regex.IsMatch(email, expectedEmailFormat) == true); 
        }
        public static bool UserName(string username)
        {
            AppDbContext db = new AppDbContext();
            var IsUserFound = db.employees.
                   Where(a => a.user_name == username).FirstOrDefault();            
                   return (IsUserFound != null ); 
          
        }
        public static bool NationalIdLen(string id)
        {           
            return ( (id.Length == 14) ); 
        }
        public static bool NationalId(string id)
        {
            AppDbContext db = new AppDbContext();
            var IsUserFound = db.employees.
                Where(a => a.employee_n_id == id).FirstOrDefault();
         
            return ((IsUserFound != null)); 
        }
        public static bool PhoneNumber(string Number)
        {
            return (Number.Length == 11);
        }


    }
    public static class DataBaseMethods
    {
        static AppDbContext db = AppDbContext.Instance;
        public static bool AddEmployee(EmployeeTable emp)
        {
                       
              
            if(ValidationMethods.CopyImage(emp.photo_path, emp.user_name,emp))
            {
                db.employees.Add(emp);
                db.SaveChanges();
               return true;
            }
            else return false;
        }
        public static bool Is_Employee(string user_name, string password)
        {
            var emp = db.employees.
               Where(a => a.user_name == user_name && a.password == password).FirstOrDefault();
            return (emp != null);
        }
        public static string getEmpName(string User_name)
        {
            return (string)db.employees.Where((x) => x.user_name == User_name).Select((x) => x.name).FirstOrDefault();
        }


    }

    
}
