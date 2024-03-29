using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;

namespace SalesUp.Business.Concrete;

public class SaleManager : ISaleService
{
   private readonly MapperlyConfig _mapperly;
   private readonly ISaleRepository _repository;

   public SaleManager(MapperlyConfig mapperly, ISaleRepository repository)
   {
      _mapperly = mapperly;
      _repository = repository;
   }
}