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

    public async Task<List<Order>> GetAllOrdersByProductIdAsync(int productId)
    {
        var result = await SalesUpDbContext
            .Orders
            .Include(o => o.OrderDetails)
            .ThenInclude(od => od.Product)
            .Where(o => o.OrderDetails.Any(x => x.ProductId == productId))
            .OrderByDescending(x => x.Id)
            .ToListAsync();
        return result;
    }
}