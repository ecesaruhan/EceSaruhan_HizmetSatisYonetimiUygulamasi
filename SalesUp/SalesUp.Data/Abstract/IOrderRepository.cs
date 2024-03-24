using SalesUp.Entity;

namespace SalesUp.Data.Abstract;

public interface IOrderRepository : IGenericRepository<Order>
{
    Task<List<Order>> GetAllOrdersByProductIdAsync(int productId);
}