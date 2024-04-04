using System.Reflection.Metadata;
using SalesUp.Shared.ViewModels.Customer;
using SalesUp.Shared.ViewModels.IdentityModels;
using SalesUp.Shared.ViewModels.Product;

namespace SalesUp.Shared.ViewModels.STask;

public class STaskViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }=DateTime.Now;
    public DateTime ModifiedDate { get; set; }=DateTime.Now;
    public DateTime CompletedDate { get; set; }=DateTime.Now;
    public string UserId { get; set; }
    public UserViewModel User { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public CustomerViewModel Customer { get; set; }
    public ProductViewModel Product { get; set; }
    public bool IsCompleted { get; set; } = false;
    public int Quantity { get; set; }
    public string Note { get; set; }
}