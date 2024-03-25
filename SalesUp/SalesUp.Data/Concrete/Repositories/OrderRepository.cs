using Microsoft.EntityFrameworkCore;
using SalesUp.Data.Abstract;
using SalesUp.Data.Concrete.Contexts;
using SalesUp.Entity;

namespace SalesUp.Data.Concrete.Repositories;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(SalesUpDbContext _context) : base(_context)
    {
    }
    private SalesUpDbContext SalesUpDbContext
    {
        get{return _dbContext as SalesUpDbContext;}
    }

    public async Task<List<Order>> GetAllOrdersBySubscriptionIdAsync(int subscriptionId)
    {
        var result = await SalesUpDbContext
            .Orders
            .Include(o => o.OrderDetails)
            .ThenInclude(od => od.Subscription)
            .Where(o => o.OrderDetails.Any(x => x.SubscriptionId == subscriptionId))
            .OrderByDescending(x => x.Id)
            .ToListAsync();
        return result;
    }
}