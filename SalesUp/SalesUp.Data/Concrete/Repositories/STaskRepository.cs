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

    public async Task<List<STask>> GetTasksByUserId(string userId)
    {
        List<STask> tasks = await SalesUpDbContext
            .Tasks
            .Where(t => t.UserId == userId)
            .ToListAsync();
        return tasks;
    }
}