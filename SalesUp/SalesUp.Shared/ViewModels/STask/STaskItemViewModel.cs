using SalesUp.Shared.ComplexTypes;
using SalesUp.Shared.ViewModels.Customer;
using SalesUp.Shared.ViewModels.Product;

namespace SalesUp.Shared.ViewModels.STask;

public class STaskItemViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }=DateTime.Now;
    public DateTime ModifiedDate { get; set; }=DateTime.Now;
    public DateTime CompletedDate { get; set; }=DateTime.Now;
    public string UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public CustomerViewModel Customer { get; set; }
    public ProductViewModel Product { get; set; }
    public TaskState TaskState { get; set; }
    public int Quantity { get; set; }
    public string Note { get; set; }
    public STaskViewModel STask { get; set; }
}