using StudentListExcelManager.IRepository;
using StudentListExcelManager.Models;

namespace StudentListExcelManager.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IGeneralRepository<Phone> Departments { get; private set; }
        public IGeneralRepository<Student> Students { get; private set; }
        

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Students = new GeneralRepository<Student>(_context);
            Departments = new GeneralRepository<Phone>(_context);
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
