using SalesUp.Shared.ViewModels.STask;

namespace SalesUp.Business.Abstract;

public interface ISTaskService
{
    Task InitializeSTaskAsync(string userId);
    Task<STaskViewModel> GetSTaskByUserIdAsync(string userId);
    Task AddToTaskAsync(string userId);
}