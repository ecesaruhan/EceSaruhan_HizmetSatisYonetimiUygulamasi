using Microsoft.AspNetCore.Mvc;

namespace SalesUp.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        return View();
    }
}