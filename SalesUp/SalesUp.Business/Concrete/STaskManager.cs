using SalesUp.Business.Abstract;
using SalesUp.Data.Abstract;
using SalesUp.Entity;
using SalesUp.Shared.ViewModels.STask;

namespace SalesUp.Business.Concrete;

public class STaskManager : ISTaskService
{
    private readonly ISTaskRepository _sTaskRepository;

    public STaskManager(ISTaskRepository sTaskRepository)
    {
        _sTaskRepository = sTaskRepository;
    }
    public async Task InitializeSTaskAsync(string userId)
    {
        await _sTaskRepository.CreateAsync(new STask { UserId = userId }); 
    }

    public Task<STaskViewModel> GetSTaskByUserIdAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task AddToTaskAsync(string userId, int productId, int quantity)
    {
        throw new NotImplementedException();
    }
}