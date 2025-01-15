using IT_Institution.DBContext;
using IT_Institution.IRepository;

namespace IT_Institution.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDBContext _appDBContext;

        AddressRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
    }
}
