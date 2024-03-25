using Microsoft.EntityFrameworkCore;
using SalesUp.Data.Abstract;
using SalesUp.Data.Concrete.Contexts;
using SalesUp.Entity;

namespace SalesUp.Data.Concrete.Repositories;

public class SaleRepository : GenericRepository<Sale>, ISaleRepository
{
    public SaleRepository(SalesUpDbContext _context) : base(_context)
    {
    }

    private SalesUpDbContext SalesUpDbContext
    {
        get{return _dbContext as SalesUpDbContext;}
    }
}