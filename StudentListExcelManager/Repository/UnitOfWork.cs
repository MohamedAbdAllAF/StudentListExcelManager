using Microsoft.EntityFrameworkCore;
using StudentListExcelManager.IRepository;
using StudentListExcelManager.Models;

namespace StudentListExcelManager.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IGeneralRepository<Phone> Phones { get; private set; }
        public IGeneralRepository<Student> Students { get; private set; }
        

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Students = new GeneralRepository<Student>(_context);
            Phones = new GeneralRepository<Phone>(_context);
        }

        public void EnsureDatabaseCreated()
        {
            // Check if the database exists
            bool databaseExists = _context.Database.CanConnect();

            if (!databaseExists)
            {
                // Create the database using migrations
                _context.Database.Migrate();
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
