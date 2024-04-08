using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;

namespace SalesUp.Business.Concrete;

public class SubscriptionManager : ISubscriptionService
{
   private readonly IMapper _mapper;
   private readonly ISubscriptionRepository _repository;


   public SubscriptionManager(IMapper mapper, ISubscriptionRepository repository)
   {
      _mapper = mapper;
      _repository = repository;
   }
}