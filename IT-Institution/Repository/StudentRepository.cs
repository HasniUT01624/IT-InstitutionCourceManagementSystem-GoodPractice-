using IT_Institution.DBContext;
using IT_Institution.IRepository;

namespace IT_Institution.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDBContext _dbContext;

        public StudentRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
