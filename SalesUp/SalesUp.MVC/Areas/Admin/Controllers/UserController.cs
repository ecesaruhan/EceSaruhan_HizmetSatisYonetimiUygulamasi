using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesUp.Entity.Identity;
using SalesUp.Shared.ViewModels.IdentityModels;

namespace SalesUp.MVC.Areas.Admin.Controllers;

[Authorize(Roles = "SuperAdmin, Admin")]
[Area("Admin")]
public class UserController : Controller
{
    private readonly UserManager<Entity.Identity.User> _userManager;

    private readonly RoleManager<Role> _roleManager;

    private readonly INotyfService _notyfService;
    // GET
    public UserController(UserManager<Entity.Identity.User> userManager, RoleManager<Role> roleManager, INotyfService notyfService)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _notyfService = notyfService;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _userManager.Users.ToListAsync());
    }

    [HttpGet]
    public async Task<IActionResult> AssignRoles(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        var userRoles = await _userManager.GetRolesAsync(user);
        var roles = await _roleManager.Roles.Select(r => new AssignRoleViewModel
        {
            RoleId = r.Id,
            RoleName = r.Name,
            IsAssigned = userRoles.Any(x => x == r.Name)
        }).ToListAsync();

        var userRolesViewModel = new UserRolesViewModel
        {
            Id = user.Id,
            Name = $"{user.FirstName} {user.LastName}",
            UserName = user.UserName,
            Roles = roles
        };
        return View(userRolesViewModel);
    }
}