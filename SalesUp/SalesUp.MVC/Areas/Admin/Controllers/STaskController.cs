using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SalesUp.Business.Abstract;

namespace SalesUp.MVC.Areas.Admin.Controllers;

[Authorize(Roles = "SuperAdmin, Admin")]
[Area("Admin")]
public class STaskController : Controller
{
    private readonly ISTaskService _taskManager;

    private readonly INotyfService _notyfService;
    // GET
    public STaskController(ISTaskService taskManager, INotyfService notyfService)
    {
        _taskManager = taskManager;
        _notyfService = notyfService;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }
}