using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;

namespace SalesUp.Business.Concrete;

public class ProductManager :IProductService
{
  private readonly MapperlyConfig _mapperly;
  private readonly IProductRepository _repository;

  public ProductManager(MapperlyConfig mapperly, IProductRepository repository)
  {
    _mapperly = mapperly;
    _repository = repository;
  }
}