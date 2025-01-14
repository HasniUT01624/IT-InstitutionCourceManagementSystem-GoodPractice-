using IT_Institution.IRepository;
using IT_Institution.IService;

namespace IT_Institution.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
    }
}
