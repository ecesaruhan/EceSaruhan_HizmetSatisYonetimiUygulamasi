using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;

namespace SalesUp.Business.Concrete;

public class MessageManager : IMessageService
{
  private readonly MapperlyConfig _mapperly;
  private readonly IMessageRepository _repository;

  public MessageManager(MapperlyConfig mapperly, IMessageRepository repository)
  {
    _mapperly = mapperly;
    _repository = repository;
  }
}