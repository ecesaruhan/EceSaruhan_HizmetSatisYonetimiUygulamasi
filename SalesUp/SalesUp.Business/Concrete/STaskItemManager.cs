using AutoMapper;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;
using SalesUp.Shared.ViewModels.STask;

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

 public async Task<STaskItemViewModel> CreateAsync(AddSTaskItemViewModel addSTaskItemViewModel)
 {
  var taskItem = _mapperly.AddSTaskItemViewModelToSTaskItem(addSTaskItemViewModel);
  taskItem.CreatedDate = DateTime.Now;
  taskItem.ModifiedDate = DateTime.Now;

  var createdTaskItem = await _repository.CreateAsync(taskItem);
  await _repository.UpdateAsync(createdTaskItem);
  var taskItemViewModel = _mapperly.STaskItemToSTaskItemViewModel(createdTaskItem);
  return taskItemViewModel;
 }

 public async Task<STaskItemViewModel> UpdateAsync(EditSTaskItemViewModel editSTaskItemViewModel)
 {
  var editedTaskItem = _mapperly.EditSTaskItemViewModelToSTaskItem(editSTaskItemViewModel);
  editedTaskItem.ModifiedDate = DateTime.Now;
  await _repository.UpdateAsync(editedTaskItem);
  var taskItemViewModel = _mapperly.STaskItemToSTaskItemViewModel(editedTaskItem);
  return taskItemViewModel;
 }

 public async Task HardDeleteAsync(int id)
 {
  var taskItem = await _repository.GetByIdAsync(t => t.Id == id);
  await _repository.HardDeleteAsync(taskItem);
 }

 public async Task<STaskItemViewModel> GetByIdAsync(int id)
 {
  var taskItem = await _repository.GetByIdAsync(t => t.Id == id);
  var taskItemViewModel = _mapperly.STaskItemToSTaskItemViewModel(taskItem);
  return taskItemViewModel;
 }
}