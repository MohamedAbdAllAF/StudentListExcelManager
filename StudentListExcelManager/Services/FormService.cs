using LMS.Views;
using StudentListExcelManager.IServices;

namespace StudentListExcelManager.Services
{
    public class FormService : IFormService
    {
        private readonly ILocationService _locationService;
        private readonly IStudentService _studentService;

        public FormService(ILocationService locationService, IStudentService studentService)
        {
            _locationService = locationService;
            _studentService = studentService;
        }

        public Form DashboardForm()
        {
            return new FRMDashboard();
        }

        public Form NewStudentForm()
        {
            return new FRMNewStudent(_locationService, _studentService);
        }
    }
}
