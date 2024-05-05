using Microsoft.EntityFrameworkCore;

namespace StudentListExcelManager.Models
{
    public class ApplicationDbContext : DbContext
    {
        string baseDirectory = AppContext.BaseDirectory;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={baseDirectory}/database.db");

        public DbSet<Student> Students { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
