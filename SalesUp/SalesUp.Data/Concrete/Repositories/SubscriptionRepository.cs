using SalesUp.Data.Abstract;
using SalesUp.Data.Concrete.Contexts;
using SalesUp.Entity;

namespace SalesUp.Data.Concrete.Repositories;

public class SubscriptionRepository : GenericRepository<Subscription>, ISubscriptionRepository
{
    public SubscriptionRepository(SalesUpDbContext _context) : base(_context)
    {
    }

    private SalesUpDbContext SalesUpDbContext
    {
        get{return _dbContext as SalesUpDbContext;}
    }
}