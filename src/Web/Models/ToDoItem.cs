using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string UserId {  get; set; } = string.Empty;
        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = null!;
        public DateTime Deadline { get; set; }
        public bool IsFinished { get; set; } = false;
    }
}
