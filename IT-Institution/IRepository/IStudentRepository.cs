using IT_Institution.Entities;

namespace IT_Institution.IRepository
{
    public interface IStudentRepository
    {
        Task<ICollection<Student>> GetAllStudents();
    }
}
