using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SalesUp.Business.Abstract;
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
    
    // GET

    public STaskController(ISTaskService taskManager, UserManager<User> userManager, INotyfService notyfService, ISTaskItemService taskItemManager)
    {
        _taskManager = taskManager;
        _userManager = userManager;
        _notyfService = notyfService;
        _taskItemManager = taskItemManager;
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
            return View(taskItemViewModel);
    }
}