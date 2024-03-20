using SalesUp.Entity;

namespace SalesUp.Data.Abstract;

public interface ISTaskRepository : IGenericRepository<STask>
{
    Task<STask> GetTaskByUserId(string userId);
    Task DeleteFromTaskAsync(int taskId, int taskItemId);
    Task ClearTaskAsync(int taskId);
}