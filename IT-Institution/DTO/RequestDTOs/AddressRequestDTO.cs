using System.ComponentModel.DataAnnotations;

namespace IT_Institution.DTO.RequestDTOs
{
    public class AddressRequestDTO
    {
        public string AddressLine1 { get; set; } = string.Empty;
        public string? AddressLine2 { get; set; } = string.Empty;
    
        public string City { get; set; } = string.Empty;
       
        public string Country { get; set; } = string.Empty;

        public int StudentId { get; set; }
    }
}
