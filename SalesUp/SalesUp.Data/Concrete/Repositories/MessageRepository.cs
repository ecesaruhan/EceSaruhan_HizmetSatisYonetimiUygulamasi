using Microsoft.EntityFrameworkCore;
using SalesUp.Data.Abstract;
using SalesUp.Data.Concrete.Contexts;
using SalesUp.Entity;

namespace SalesUp.Data.Concrete.Repositories;

public class MessageRepository : GenericRepository<Message>, IMessageRepository
{
    public MessageRepository(SalesUpDbContext context) : base(context)
    {
    }

    SalesUpDbContext SalesUpDbContext
    {
        get {return DbContext as SalesUpDbContext;}
    }
}