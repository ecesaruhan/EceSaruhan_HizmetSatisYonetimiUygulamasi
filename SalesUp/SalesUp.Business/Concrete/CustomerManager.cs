using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;

namespace SalesUp.Business.Concrete;

public class CustomerManager : ICustomerService
{
    private readonly MapperlyConfig _mapperly;
    private readonly ICustomerRepository _repository;

    public CustomerManager(MapperlyConfig mapperly, ICustomerRepository repository)
    {
        _mapperly = mapperly;
        _repository = repository;
    }
}