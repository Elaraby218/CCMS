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
                    _instance.Database.EnsureCreated();
                }
                return _instance;
            }
        }
        public AppDbContext(){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1ULGF16\\SQLEXPRESS;Initial Catalog=SSMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            // optionsBuilder.("Data Source=mydatabase.db");
        }
    }
}
