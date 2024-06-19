using System.ComponentModel.DataAnnotations;

namespace Api.DTOs
{
    public record UserDTO {

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    };
}
