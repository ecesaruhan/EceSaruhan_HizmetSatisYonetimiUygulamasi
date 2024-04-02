using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Data.Abstract;
using SalesUp.Entity;
using SalesUp.Shared.ViewModels.STask;

namespace SalesUp.Business.Concrete;

public class STaskItemManager : ISTaskItemService
{
 private readonly MapperlyConfig _mapperly;
 private readonly ISTaskItemRepository _repository;
 private readonly ISTaskRepository _taskRepository;


 public STaskItemManager(MapperlyConfig mapperly, ISTaskItemRepository repository, ISTaskRepository taskRepository)
 {
  _mapperly = mapperly;
  _repository = repository;
  _taskRepository = taskRepository;
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

 public async Task<List<STaskItemViewModel>> GetTaskItemsByTaskIdAsync(int taskId)
 {
  var taskItems = await _repository.GetAllAsync(t => t.STaskId == taskId);
  var taskItemsViewModel = _mapperly.STaskItemListToSTaskItemListViewModel(taskItems);
  return taskItemsViewModel;
 }

 public async Task ClearTaskAsync(int taskId)
 {
  var task = await _taskRepository.GetByIdAsync(t=>t.Id == taskId, source=>source.Include(x=>x.TaskItems));
   task.TaskItems = new List<STaskItem>();
    await _taskRepository.UpdateAsync(task);
 }
}