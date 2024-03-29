using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;
using SalesUp.Entity;
using SalesUp.Shared.ViewModels.STask;

namespace SalesUp.Business.Concrete;

public class STaskManager : ISTaskService
{
    private readonly MapperlyConfig _mapperly;
    private readonly ISTaskRepository _repository;

    public STaskManager(MapperlyConfig mapperly, ISTaskRepository repository)
    {
        _mapperly = mapperly;
        _repository = repository;
    }

    public async Task InitializeSTaskAsync(string userId)
    {
        await _repository.CreateAsync(new STask { UserId = userId }); 
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