using Crito.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Crito.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected DatabaseContext()
        {
        }

        public DbSet<ContactFormEntity> ContactForms { get; set; }
        public DbSet<NewsletterFormEntity> NewsletterForms { get; set;}
    }
}
