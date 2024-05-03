using Microsoft.EntityFrameworkCore;

namespace StudentListExcelManager.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=database.db");

        public DbSet<Student> Students { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
