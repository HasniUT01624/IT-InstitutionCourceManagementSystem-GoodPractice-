using IT_Institution.DTO.ResponseDTOs;
using IT_Institution.Entities;
using IT_Institution.IRepository;
using IT_Institution.IService;
using System.Numerics;

namespace IT_Institution.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }



        public async Task<ICollection<StudentResponseDTO>> GetAllStudents()
        {
            var students = await _studentRepository.GetAllStudents();
            var studentList = new List<StudentResponseDTO>();
            foreach (var student in students)
            {
                var responseDTO = new StudentResponseDTO()
                {
                    Id = student.Id,
                    Nic = student.Nic,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Email = student.Email,
                    Phone = student.Phone,
                    Password = student.Password,

                };
                studentList.Add(responseDTO);
            }
            return studentList;
        }



    }
}
