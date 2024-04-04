using SalesUp.Entity.Identity;
using SalesUp.Shared.ComplexTypes;

namespace SalesUp.Entity;

public class STask
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }=DateTime.Now;
    public DateTime ModifiedDate { get; set; }=DateTime.Now;
    public DateTime CompletedDate { get; set; }=DateTime.Now;
    public string UserId { get; set; }
    public User User { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Customer Customer { get; set; }
    public Product Product { get; set; }
    public bool IsCompleted { get; set; } = false;
    public Role Role { get; set; }
    public int Quantity { get; set; }
    public string Note { get; set; }
}