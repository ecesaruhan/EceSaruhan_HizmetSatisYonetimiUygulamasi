using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SalesUp.Business.Abstract;

namespace SalesUp.MVC.Areas.Admin.Controllers;

[Authorize(Roles = "SuperAdmin, Admin")]
[Area("Admin")]
public class OrderController : Controller
{
    private readonly IOrderService _orderManager;

    private readonly ISubscriptionService _subscriptionManager;
    
    // GET
    public OrderController(IOrderService orderManager, ISubscriptionService subscriptionManager)
    {
        _orderManager = orderManager;
        _subscriptionManager = subscriptionManager;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }
}