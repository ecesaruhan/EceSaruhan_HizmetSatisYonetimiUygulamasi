using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SalesUp.MVC.Areas.Admin.Controllers;

[Authorize(Roles = "SuperAdmin, Admin")]
[Area("Admin")]
public class CustomerController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        return View();
    }
}