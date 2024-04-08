using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;

namespace SalesUp.Business.Concrete;

public class MessageManager : IMessageService
{
  private readonly IMapper _mapper;
  private readonly IMessageRepository _repository;


  public MessageManager(IMapper mapper, IMessageRepository repository)
  {
    _mapper = mapper;
    _repository = repository;
  }
}