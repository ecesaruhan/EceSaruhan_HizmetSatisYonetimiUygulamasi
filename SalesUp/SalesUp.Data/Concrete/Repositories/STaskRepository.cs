using Microsoft.EntityFrameworkCore;
using SalesUp.Data.Abstract;
using SalesUp.Data.Concrete.Contexts;
using SalesUp.Entity;
using SalesUp.Entity.Identity;

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
    
    
    public async Task DeleteAllAsync(int userId)
    {
        var deletedTaskList = await SalesUpDbContext
            .Tasks
            .Include(x=>x.User)
            .Where(x => x.UserId == userId)
            .ToListAsync();

        SalesUpDbContext.Tasks.RemoveRange(deletedTaskList);
        await SalesUpDbContext.SaveChangesAsync();
    }
}