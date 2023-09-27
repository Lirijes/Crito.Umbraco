using Crito.Models.Enteties;
using Microsoft.EntityFrameworkCore;

namespace Crito.Contexts
{
    public class DatabaseContext : DbContext
    {
        private readonly string _connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lirij\OneDrive\Skrivbord\crito_local_db\crito_db.mdf;Integrated Security=True;Connect Timeout=30";

        protected DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionstring);
        }

        public DbSet<ContactFormEntity> ContactFormEntities { get; set; }
    }
}
