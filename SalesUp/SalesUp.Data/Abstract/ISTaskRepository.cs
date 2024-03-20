using SalesUp.Entity;

namespace SalesUp.Data.Abstract;

public interface ISTaskRepository : IGenericRepository<STask>
{
    Task<List<STask>> GetTasksByUserId(string userId);
}