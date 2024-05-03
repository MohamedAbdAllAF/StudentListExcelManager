using StudentListExcelManager.Models;

namespace StudentListExcelManager.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGeneralRepository<Phone> Departments { get; }
        IGeneralRepository<Student> Students { get; }
        
        int Save();
        Task<int> SaveAsync();
    }
}
