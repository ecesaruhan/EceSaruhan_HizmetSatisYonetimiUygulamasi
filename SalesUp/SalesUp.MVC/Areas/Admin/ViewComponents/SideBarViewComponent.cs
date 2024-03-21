using Microsoft.AspNetCore.Mvc;

namespace SalesUp.MVC.Areas.Admin.ViewComponents;

public class SideBarViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}