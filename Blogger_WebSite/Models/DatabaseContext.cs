using Microsoft.EntityFrameworkCore;

namespace Blogger_WebSite.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Bloggers> Bloggers { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<Contacts> Contacts { get; set; }

        public DbSet<Projects> Projects { get; set; }

        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-FEBL0K35\SQLEXPRESS;Database=BlogDatabase;Trusted_Connection=true;encrypt=false");
        }
    }
}
