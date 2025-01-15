using IT_Institution.IRepository;
using IT_Institution.IService;

namespace IT_Institution.Service
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

       AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
    }
}
