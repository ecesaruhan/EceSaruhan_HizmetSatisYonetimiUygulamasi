using SalesUp.Entity;

namespace SalesUp.Data.Abstract;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<List<Product>> GetProductsByUserIdAsync(string userId);
}