using Api.Enums;
using System.ComponentModel.DataAnnotations;

namespace Api.DTOs
{
    public record MissionDTO
    {

        [Required]
        [StringLength(40, MinimumLength = 5)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public int UserId { get; set; }

        public int Status { get; set; }
    }
}
