using StudentListExcelManager.IRepository;
using StudentListExcelManager.IServices;
using StudentListExcelManager.Models;
using StudentListExcelManager.Repository;

namespace StudentListExcelManager.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<int> AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteStudentById(int StudentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentById(int StudentId)
        {
            throw new NotImplementedException();
        }
    }
}
