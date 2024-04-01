using SalesUp.Shared.ViewModels.STask;

namespace SalesUp.Business.Abstract;

public interface ISTaskItemService
{
    Task<STaskItemViewModel> CreateAsync(AddSTaskItemViewModel addSTaskItemViewModel);
    Task<STaskItemViewModel> UpdateAsync(EditSTaskItemViewModel editSTaskItemViewModel);
    Task HardDeleteAsync(int id);
    Task<STaskItemViewModel> GetByIdAsync(int taskItemId);
}