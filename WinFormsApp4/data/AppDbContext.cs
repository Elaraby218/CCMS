using Microsoft.EntityFrameworkCore;

namespace WinFormsApp4.data
{
    internal partial class AppDbContext : DbContext
    {
        private static AppDbContext _instance;
        public static AppDbContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppDbContext();
                }
               // Console.WriteLine("AppDbContext.Instance");
                return _instance;
            }
        }
        public AppDbContext(){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-114872S;Initial Catalog=SSMS;Integrated Security=True;Connect Timeout=30;Encry" +
                "" +
                "pt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
