using CourseWork6sem.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseWork6sem.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
     
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookFound> BookFounds { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Library> Libraries { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
