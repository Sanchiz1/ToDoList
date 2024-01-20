using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }
        public string UserId {  get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }
        public bool IsFinished { get; set; } = false;
    }
}
