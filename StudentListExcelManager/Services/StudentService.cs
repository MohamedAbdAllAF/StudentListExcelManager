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
            _unitOfWork.EnsureDatabaseCreated();
        }

        public async Task<int> AddStudent(Student student)
        {
            try
            {
                Student newStudent = new Student
                {
                    NameArabic = student.NameArabic,
                    NameEnglish = student.NameEnglish,
                    NationalID = student.NationalID,
                    Email = student.Email,
                    Password = student.Password,
                    ConfirmPasswor = student.ConfirmPasswor,
                    PlaceOfBirth = student.PlaceOfBirth,
                    Gender = student.Gender,
                    StudentCode = student.StudentCode,
                    Nationality = student.Nationality,
                    Religion = student.Religion,
                    ReleasePlace = student.ReleasePlace,
                    DateOfBirth = student.DateOfBirth,
                    CountryId = student.CountryId,
                    GovernorateId = student.GovernorateId,
                    CityId = student.CityId,
                    Street = student.Street,
                    PostalCode = student.PostalCode,
                    PreQualification = student.PreQualification,
                    SeatNumber = student.SeatNumber,
                    QualificationYear = student.QualificationYear,
                    Degree = student.Degree,
                    ParentName = student.ParentName,
                    ParentJob = student.ParentJob,
                    ParentCountryId = student.ParentCountryId,
                    ParentGovernorateId = student.ParentGovernorateId,
                    ParentCityId = student.ParentCityId,
                    ParentStreet = student.ParentStreet,
                    PostalCodeOfParent = student.PostalCodeOfParent,
                    Phones = new List<Phone>()
                };

                var entity = await _unitOfWork.Students.AddAsync(newStudent);

                await _unitOfWork.SaveAsync();

                List<Phone> phones = student.Phones.Select(ph =>
                            new Phone
                            {
                                StudentId = entity.id,
                                PhoneNumber = ph.PhoneNumber,
                                Type = ph.Type,
                            }).ToList();

                foreach (var phone in phones)
                {
                    await _unitOfWork.Phones.AddAsync(phone);
                }

                var result = await _unitOfWork.SaveAsync();

                return result;
            }
            catch (Exception ex)
            {
                return -1;
            }
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
