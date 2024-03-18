using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalesUp.MVC.Models;

namespace SalesUp.MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
}