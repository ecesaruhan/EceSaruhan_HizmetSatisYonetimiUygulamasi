using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;

namespace SalesUp.Business.Concrete;

public class SaleManager : ISaleService
{
   private readonly IMapper _mapper;
   private readonly ISaleRepository _repository;


   public SaleManager(IMapper mapper, ISaleRepository repository)
   {
      _mapper = mapper;
      _repository = repository;
   }
}