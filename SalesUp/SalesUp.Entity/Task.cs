using SalesUp.Entity.Identity;

namespace SalesUp.Entity;

public class Task
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }=DateTime.Now;
    public string UserId { get; set; }
    public User User { get; set; }
    public List<TaskItem> TaskItems { get; set; } = new List<TaskItem>();
}