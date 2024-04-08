using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;

namespace SalesUp.Business.Concrete;

public class CustomerManager : ICustomerService
{
    private readonly IMapper _mapper;
    private readonly ICustomerRepository _repository;


    public CustomerManager(IMapper mapper, ICustomerRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }
}