using Microsoft.EntityFrameworkCore;
using SalesUp.Data.Abstract;
using SalesUp.Data.Concrete.Contexts;
using SalesUp.Entity;

namespace SalesUp.Data.Concrete.Repositories;

public class STaskRepository : GenericRepository<STask>, ISTaskRepository
{
    public STaskRepository(SalesUpDbContext _context) : base(_context)
    {
    }

    private SalesUpDbContext SalesUpDbContext
    {
        get{return _dbContext as SalesUpDbContext;}
    }

    public async Task<STask> GetTaskByUserId(string userId)
    {
        var task = await SalesUpDbContext
            .Tasks
            .Where(t => t.UserId == userId)
            .FirstOrDefaultAsync();
        return task;
    }

    public async Task DeleteFromTaskAsync(int taskId, int taskItemId)
    {
        var deletedTaskItem = await SalesUpDbContext
            .TaskItems
            .Where(ti => ti.STask.Id == taskId && ti.Id == taskItemId)
            .FirstOrDefaultAsync();

        SalesUpDbContext.TaskItems.Remove(deletedTaskItem);
        await SalesUpDbContext.SaveChangesAsync();
    }

    public async Task ClearTaskAsync(int taskId)
    {
        var deletedTaskItems = await SalesUpDbContext
            .TaskItems
            .Where(ti => ti.STask.Id == taskId)
            .ToListAsync();
        SalesUpDbContext.TaskItems.RemoveRange(deletedTaskItems);
        await SalesUpDbContext.SaveChangesAsync();
    }
}