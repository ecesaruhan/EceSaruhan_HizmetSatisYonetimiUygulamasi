using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;

namespace SalesUp.Business.Concrete;

public class STaskItemManager : ISTaskItemService
{
 private readonly MapperlyConfig _mapperly;
 private readonly ISTaskItemRepository _repository;

 public STaskItemManager(MapperlyConfig mapperly, ISTaskItemRepository repository)
 {
  _mapperly = mapperly;
  _repository = repository;
 }
}