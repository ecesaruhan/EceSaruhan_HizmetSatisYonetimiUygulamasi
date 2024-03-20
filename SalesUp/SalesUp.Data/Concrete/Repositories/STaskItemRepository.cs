using Microsoft.EntityFrameworkCore;
using SalesUp.Data.Abstract;
using SalesUp.Data.Concrete.Contexts;
using SalesUp.Entity;

namespace SalesUp.Data.Concrete.Repositories;

public class STaskItemRepository : GenericRepository<STaskItem>, ISTaskItemRepository
{
    public STaskItemRepository(SalesUpDbContext _context) : base(_context)
    {
    }

    private SalesUpDbContext SalesUpDbContext
    {
        get{return _dbContext as SalesUpDbContext;}
    }

    public async Task ChangeQuantityAsync(STaskItem taskItem, int quantity)
    {
        taskItem.Quantity = quantity;
        SalesUpDbContext.Update(taskItem);
        await SalesUpDbContext.SaveChangesAsync();
    }
}