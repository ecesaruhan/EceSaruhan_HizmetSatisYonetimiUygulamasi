using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;

namespace SalesUp.Business.Concrete;

public class SubscriptionManager : ISubscriptionService
{
   private readonly MapperlyConfig _mapperly;
   private readonly ISubscriptionRepository _repository;

   public SubscriptionManager(MapperlyConfig mapperly, ISubscriptionRepository repository)
   {
      _mapperly = mapperly;
      _repository = repository;
   }
}