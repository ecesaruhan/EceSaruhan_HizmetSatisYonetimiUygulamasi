using SalesUp.Shared.ComplexTypes;
using SalesUp.Shared.ViewModels.Customer;
using SalesUp.Shared.ViewModels.Product;

namespace SalesUp.Shared.ViewModels.STask;

public class EditSTaskItemViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }=DateTime.Now;
    public DateTime ModifiedDate { get; set; }=DateTime.Now;
    public CustomerViewModel Customer { get; set; }
    public ProductViewModel Product { get; set; }
    public TaskState TaskState { get; set; }
    public string Note { get; set; }
    public STaskViewModel STask { get; set; }
}
