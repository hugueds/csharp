using Microsoft.EntityFrameworkCore; 

namespace ContactList.Models
{
    public class ContactsDbContext : DbContext
    {
        public DbSet<Contact> Contacts {get;set;}

        public ContactsDbContext(DbContextOptions<ContactsDbContext> options) : base(options)
        {
            
        }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Contacts.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
            .Property(c => c.FirstName).IsRequired().HasMaxLength(100);
        }

    }
}