
using Microsoft.EntityFrameworkCore;
using IntecapBooks.Models;
namespace IntecapBooks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<BookModel> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
        public ApplicationDbContext()
        { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IntecapBooks;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Novela" },
                new Category() { Id = 2, Name = "SciFi" },
                new Category() { Id = 3, Name = "Científico" });
            modelBuilder.Entity<CoverType>().HasData(
                new CoverType() { Id = 1, Name = "Tapa Blanda" },
                new CoverType() { Id = 2, Name = "Tapa Dura" },
                new CoverType() { Id = 3, Name = "Digital" });
        }
    }
}
