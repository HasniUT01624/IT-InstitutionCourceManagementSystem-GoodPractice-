using IT_Institution.DTO.ResponseDTOs;

namespace IT_Institution.IService
{
    public interface IStudentService
    {
        Task<ICollection<StudentResponseDTO>> GetAllStudents();
    }
}
