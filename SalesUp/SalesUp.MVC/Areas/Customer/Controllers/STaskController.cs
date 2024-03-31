using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SalesUp.MVC.Areas.User.Controllers;

[Authorize(Roles = "Customer")]
[Area("Customer")]
public class STaskController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        return View();
    }
}