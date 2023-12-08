using WinFormsApp4;
using WinFormsApp4.data;
namespace funcs
{
    // dont touch
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
                MessageBox.Show("Done", "Registration complete", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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

        public static void CopyImage(string source , string usernow)
        {
            string dest = "J:\\c#\\WinFormsApp4\\WinFormsApp4\\bin\\Debug\\net6.0-windows\\images" +
                           $"\\{usernow}.jpg";
            File.Copy(source, dest); 
        }
    }
    public static class DataBaseMethods
    {
        static AppDbContext db = AppDbContext.Instance;
        public static void AddEmployee(EmployeeTable emp)
        {
            {              
                db.employees.Add(emp);
                db.SaveChanges();
            }
            ValidationMethods.CopyImage(emp.photo_path, emp.user_name); 
          
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
