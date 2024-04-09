using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SalesUp.Business.Abstract;
using SalesUp.Entity.Identity;
using SalesUp.Shared.ResponseViewModels;
using SalesUp.Shared.ViewModels.STask;

namespace SalesUp.MVC.Areas.Admin.Controllers;

[Authorize(Roles = "SuperAdmin, Admin")]
[Area("Admin")]
public class STaskController : Controller
{
    private readonly ISTaskService _taskManager;
    private readonly UserManager<User> _userManager;
    private readonly INotyfService _notyfService;
    private readonly IMapper _mapper;
    
    // GET


    public STaskController(ISTaskService taskManager, UserManager<User> userManager, INotyfService notyfService, IMapper mapper)
    {
        _taskManager = taskManager;
        _userManager = userManager;
        _notyfService = notyfService;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index(int userId)
    {
        Response<List<STaskViewModel>> tasks = await _taskManager.GetTasksByUserIdAsync(userId);
        return View(tasks.Data);
    }

    public async Task<IActionResult> UpdateIsCompleted(int id)
    {
        var result = await _taskManager.UpdateIsCompletedAsync(id);
        var task = await _taskManager.GetByIdAsync(id);
        return Json(task.Data.IsCompleted);
    }
    public async Task<IActionResult> Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(AddSTaskViewModel addSTaskViewModel)
    {
        var userId = _userManager.GetUserId(User);
        addSTaskViewModel.UserId = userId;
        
            var result = await _taskManager.CreateAsync(addSTaskViewModel);
            if (result.IsSucceeded)
            {
                _notyfService.Success("Görev başarıyla kaydedildi.");
                return RedirectToAction("Index");
            }
            else
            {
                _notyfService.Error(result.Error);
                return View(addSTaskViewModel);
        }
    }
    

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var task = await _taskManager.GetByIdAsync(id);
        STaskViewModel taskViewModel = task.Data;
        EditSTaskViewModel model = new EditSTaskViewModel
        {
            Id = taskViewModel.Id,
            Title = taskViewModel.Title,
            IsCompleted = taskViewModel.IsCompleted,
            Note = taskViewModel.Note,
            CreatedDate = taskViewModel.CreatedDate,
            ModifiedDate = taskViewModel.ModifiedDate
        };
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EditSTaskViewModel editSTaskViewModel)
    {
        if (ModelState.IsValid)
        {
            var result = await _taskManager.UpdateAsync(editSTaskViewModel);
            if(result.IsSucceeded) _notyfService.Success("Ürün başarıyla güncellenmiştir.");
            else _notyfService.Error(result.Error);
            return RedirectToAction("Index");
        }
        return View(editSTaskViewModel);
    }

    public async Task HardDelete(int id)
    {
        await _taskManager.HardDeleteAsync(id);
        _notyfService.Success("Görev başarıyla silinmiştir.");
    }

    public async Task DeleteAllTasks(int userId)
    {
        await _taskManager.DeleteAllAsync(userId);
        _notyfService.Success("Tüm görevler başarıyla silinmiştir.");
    }
}