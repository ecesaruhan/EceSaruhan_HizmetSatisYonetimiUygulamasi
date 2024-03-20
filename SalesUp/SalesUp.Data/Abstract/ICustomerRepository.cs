using SalesUp.Entity;

namespace SalesUp.Data.Abstract;

public interface ICustomerRepository : IGenericRepository<Customer>
{
    Task<List<Customer>> GetTopCustomers(int n);
}