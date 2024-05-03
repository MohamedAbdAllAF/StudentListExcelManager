using StudentListExcelManager.Models;

namespace StudentListExcelManager.IServices
{
    public interface IStudentService
    {
        Task<int> AddStudent(Student student);
        Task<int> DeleteStudentById(int StudentId);
        Task<Student> GetStudentById(int StudentId);
        Task<List<Student>> GetAllStudents();
    }
}
