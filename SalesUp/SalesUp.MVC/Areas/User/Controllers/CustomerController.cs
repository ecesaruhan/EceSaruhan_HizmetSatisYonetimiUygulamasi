using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SalesUp.MVC.Areas.User.Controllers;

[Authorize(Roles = "User")]
[Area("User")]
public class CustomerController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        return View();
    }
}