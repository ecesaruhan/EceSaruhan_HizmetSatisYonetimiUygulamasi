using System.Security.AccessControl;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
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
    private readonly MapperlyConfig _mapperly;
    
    // GET


    public STaskController(ISTaskService taskManager, UserManager<User> userManager, INotyfService notyfService, MapperlyConfig mapperly)
    {
        _taskManager = taskManager;
        _userManager = userManager;
        _notyfService = notyfService;
        _mapperly = mapperly;
    }

    public async Task<IActionResult> Index(bool isCompleted = false)
    {
        Response<List<STaskViewModel>> result = await _taskManager.GetAllNonCompletedAsync(isCompleted);
        ViewBag.ShowIsComplete = isCompleted;
        return View(result.Data);

    }

    public async Task<IActionResult> UpdateIsCompleted(int id)
    {
        var result = await _taskManager.UpdateIsCompletedAsync(id);
        var task = await _taskManager.GetByIdAsync(id);
        return Json(task.Data.IsCompleted);
    }
    public async Task<IActionResult> Create()
    {
        AddSTaskViewModel model = new AddSTaskViewModel();
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Create(AddSTaskViewModel addTaskViewModel)
    {
        if (ModelState.IsValid)
        {
            var result = await _taskManager.CreateAsync(addTaskViewModel);
            if(result.IsSucceeded) _notyfService.Success("Görev başarıyla kaydedildi.");
            else _notyfService.Error(result.Error);
            return RedirectToAction("Index");
        }

        return View(addTaskViewModel);
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

    public async Task DeleteAllTasks(string userId)
    {
        await _taskManager.DeleteAllAsync(userId);
        _notyfService.Success("Tüm görevler başarıyla silinmiştir.");
    }
}