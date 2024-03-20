using SalesUp.Entity;

namespace SalesUp.Data.Abstract;

public interface ISTaskItemRepository : IGenericRepository<STaskItem>
{
    Task ChangeQuantityAsync(STaskItem taskItem, int quantity);
}