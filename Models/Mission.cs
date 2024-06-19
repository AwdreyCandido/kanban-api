using Api.Enums;
using System.Text.Json.Serialization;
namespace Api.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; } = Status.ToDo;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }
    }
}
