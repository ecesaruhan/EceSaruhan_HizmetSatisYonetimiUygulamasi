using Microsoft.EntityFrameworkCore;
using SalesUp.Data.Abstract;
using SalesUp.Data.Concrete.Contexts;
using SalesUp.Entity;

namespace SalesUp.Data.Concrete.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(SalesUpDbContext context) : base(context)
    {
    }

    private SalesUpDbContext SalesUpDbContext
    {
        get{return DbContext as SalesUpDbContext;}
    }

    public async Task<List<Product>> GetProductsByUserIdAsync(string userId)
    {
        List<Product> products = await SalesUpDbContext
            .Products
            .Where(p=>p.User.Id==userId)
            .ToListAsync();
        return products;

    }
}