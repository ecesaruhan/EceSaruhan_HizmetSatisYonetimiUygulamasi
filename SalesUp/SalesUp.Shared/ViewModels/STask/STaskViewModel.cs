using System.Reflection.Metadata;
using SalesUp.Shared.ViewModels.IdentityModels;

namespace SalesUp.Shared.ViewModels.STask;

public class STaskViewModel
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public List<STaskItemViewModel> TaskItems { get; set; }
}