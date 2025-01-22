using IT_Institution.DBContext;
using IT_Institution.Entities;
using IT_Institution.IRepository;
using Microsoft.EntityFrameworkCore;

namespace IT_Institution.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDBContext _dbContext;

        public StudentRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<Student>> GetAllStudents()
        {
            var students = await _dbContext.Students.Include(a => a.Address).ToListAsync();
            return students;
        }
    }
}
