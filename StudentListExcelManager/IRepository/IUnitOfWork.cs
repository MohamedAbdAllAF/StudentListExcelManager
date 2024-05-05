using StudentListExcelManager.Models;

namespace StudentListExcelManager.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGeneralRepository<Phone> Phones { get; }
        IGeneralRepository<Student> Students { get; }
        void EnsureDatabaseCreated();
        int Save();
        Task<int> SaveAsync();
    }
}
