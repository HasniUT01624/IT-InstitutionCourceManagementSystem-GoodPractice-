using IT_Institution.Entities;
using System.ComponentModel.DataAnnotations;

namespace IT_Institution.DTO.ResponseDTOs
{
    public class StudentResponseDTO
    {
        public int Id { get; set; }
      
        public string Nic { get; set; } = string.Empty;
        
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? Gender { get; set; } = string.Empty;
        
        public string Email { get; set; } = string.Empty;
        
        public string Phone { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;

       
        public AddressResponseDTO? Address { get; set; }
    }
}
