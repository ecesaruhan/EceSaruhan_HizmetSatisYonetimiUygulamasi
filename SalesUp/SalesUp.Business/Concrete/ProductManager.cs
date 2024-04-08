using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;

namespace SalesUp.Business.Concrete;

public class ProductManager :IProductService
{
  private readonly IMapper _mapper;
  private readonly IProductRepository _repository;

  public ProductManager(IMapper mapper, IProductRepository repository)
  {
    _mapper = mapper;
    _repository = repository;
  }
}