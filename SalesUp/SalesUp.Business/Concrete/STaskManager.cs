using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

    public async Task<STaskViewModel> GetSTaskByUserIdAsync(string userId)
    {
        var tasks = await _repository.GetTaskByUserId(userId);
        var tasksViewModel = _mapperly.STaskToSTaskViewModel(tasks);
        return tasksViewModel;
    }

    public async Task AddToTaskAsync(string userId)
    {
        var task = await _repository.GetTaskByUserId(userId);
        task.TaskItems.Add(new STaskItem
        {
            STaskId = task.Id
        });
        await _repository.UpdateAsync(task);
    }
}