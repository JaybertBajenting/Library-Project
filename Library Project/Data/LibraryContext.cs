
using Microsoft.EntityFrameworkCore;
using Library_Project.Models;
namespace Library_Project.Data
{
    public class LibraryContext: DbContext
    {

        public DbSet<Author> Authors { get; set; } = null!;

        public DbSet<Book> Books { get; set; } = null!;
        
        public DbSet<Category> Categories { get; set; } = null!;
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Categories)
                .WithMany(c => c.Books)
                .UsingEntity(j => j.ToTable("tbl_book_category"));
        }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }
    }
}
