using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SalesUp.Business.Abstract;

namespace SalesUp.MVC.Areas.Admin.Controllers;

[Authorize(Roles = "SuperAdmin, Admin")]
[Area("Admin")]
public class SubscriptionController : Controller
{
    private readonly ISubscriptionService _subscriptionManager;

    private readonly INotyfService _notyfService;
    // GET
    public SubscriptionController(ISubscriptionService subscriptionManager, INotyfService notyfService)
    {
        _subscriptionManager = subscriptionManager;
        _notyfService = notyfService;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }
    
}

// CRUD işlemleri eklenecek.