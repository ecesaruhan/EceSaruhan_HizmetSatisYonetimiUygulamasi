using SalesUp.Entity;

namespace SalesUp.Data.Abstract;

public interface ISTaskRepository : IGenericRepository<STask>
{
    Task<List<STask>> GetTasksByUserIdAsync(string userId);
    Task DeleteAllAsync(string userId);
}