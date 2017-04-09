using Microsoft.EntityFrameworkCore;

namespace ContactList.Models
{
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books {get;set;}

        public BooksDbContext(DbContextOptions<BooksDbContext> opt) : base(opt)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Books.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>();            
        }



    }
}