using SalesUp.Entity.Identity;

namespace SalesUp.Entity;

public class STask
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }=DateTime.Now;
    public string UserId { get; set; }
    public User User { get; set; }
    public List<STaskItem> TaskItems { get; set; } = new List<STaskItem>();
}