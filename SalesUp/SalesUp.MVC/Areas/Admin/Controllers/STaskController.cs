using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SalesUp.Business.Abstract;
using SalesUp.Business.Mappings;
using SalesUp.Entity.Identity;
using SalesUp.Shared.ViewModels.STask;

namespace SalesUp.MVC.Areas.Admin.Controllers;

[Authorize(Roles = "SuperAdmin, Admin")]
[Area("Admin")]
public class STaskController : Controller
{
    private readonly ISTaskService _taskManager;
    private readonly UserManager<User> _userManager;
    private readonly INotyfService _notyfService;
    private readonly ISTaskItemService _taskItemManager;
    private readonly MapperlyConfig _mapperly;
    
    // GET


    public STaskController(ISTaskService taskManager, UserManager<User> userManager, INotyfService notyfService, ISTaskItemService taskItemManager, MapperlyConfig mapperly)
    {
        _taskManager = taskManager;
        _userManager = userManager;
        _notyfService = notyfService;
        _taskItemManager = taskItemManager;
        _mapperly = mapperly;
    }

    public async Task<IActionResult> Index()
    {
        var userId = _userManager.GetUserId(User);
        var task = await _taskManager.GetSTaskByUserIdAsync(userId);
        return View(task);
    }
    public async Task<IActionResult> AddToTask(int taskItemId)
    {
        var userId = _userManager.GetUserId(User);
        await _taskManager.AddToTaskAsync(userId);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(AddSTaskItemViewModel addTaskItemViewModel)
    {
            var taskItemViewModel = await _taskItemManager.CreateAsync(addTaskItemViewModel);
            _notyfService.Success("Görev başarıyla kaydedilmiştir.");
            return RedirectToAction("Index");
    }

    public async Task<IActionResult> DeleteItem(int id)
    {
        await _taskItemManager.HardDeleteAsync(id);
        return RedirectToAction("Index");
    }

    public async Task ClearTask(int id)
    {
        await _taskItemManager.ClearTaskAsync(id);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var taskItem = await _taskItemManager.GetByIdAsync(id);
        EditSTaskItemViewModel editedTaskItem = new EditSTaskItemViewModel
        {
            Id = taskItem.Id,
            Title = taskItem.Title,
            Note = taskItem.Note,
            Customer = taskItem.Customer,
            Product = taskItem.Product,
            TaskState = taskItem.TaskState,
        };
        return View(editedTaskItem);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EditSTaskItemViewModel editSTaskItemViewModel)
    {
        var result = await _taskItemManager.UpdateAsync(editSTaskItemViewModel);
        return RedirectToAction("Index");
    }
}