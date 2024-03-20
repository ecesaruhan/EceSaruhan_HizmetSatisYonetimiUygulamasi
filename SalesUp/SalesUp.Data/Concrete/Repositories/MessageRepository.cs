using Microsoft.EntityFrameworkCore;
using SalesUp.Data.Abstract;
using SalesUp.Data.Concrete.Contexts;
using SalesUp.Entity;

namespace SalesUp.Data.Concrete.Repositories;

public class MessageRepository : GenericRepository<Message>, IMessageRepository
{
    public MessageRepository(SalesUpDbContext _context) : base(_context)
    {
    }

    SalesUpDbContext SalesUpDbContext
    {
        get {return _dbContext as SalesUpDbContext;}
    }
}