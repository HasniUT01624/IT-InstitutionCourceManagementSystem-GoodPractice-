using System.ComponentModel.DataAnnotations;

namespace IT_Institution.DTO.ResponseDTOs
{
    public class AddressResponseDTO
    {
        public Guid Id { get; set; }
      
        public string AddressLine1 { get; set; } = string.Empty;
        public string? AddressLine2 { get; set; } = string.Empty;
       
        public string City { get; set; } = string.Empty;
       
        public string Country { get; set; } = string.Empty;

        public int StudentId { get; set; }
    }
}
