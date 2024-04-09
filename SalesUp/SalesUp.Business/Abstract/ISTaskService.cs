using SalesUp.Shared.ResponseViewModels;
using SalesUp.Shared.ViewModels.STask;

namespace SalesUp.Business.Abstract;

public interface ISTaskService
{
    Task<Response<STaskViewModel>> CreateAsync(AddSTaskViewModel addSTaskViewModel);
    Task<Response<STaskViewModel>> UpdateAsync(EditSTaskViewModel editSTaskViewModel);
    Task<Response<NoContent>> HardDeleteAsync(int id);
    Task<Response<STaskViewModel>> GetByIdAsync(int id);
    Task<Response<List<STaskViewModel>>> GetTasksByUserIdAsync(int userId);
    Task<Response<NoContent>> DeleteAllAsync(int userId);
    Task<Response<NoContent>> UpdateIsCompletedAsync(int id);
    Task<Response<List<STaskViewModel>>> GetAllNonCompletedAsync(int userId, bool isCompleted = false);
}