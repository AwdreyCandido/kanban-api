using Api.Enums;
namespace Api.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; } = Status.ToDo;
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
