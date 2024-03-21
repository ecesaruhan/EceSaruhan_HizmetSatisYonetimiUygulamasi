using Microsoft.AspNetCore.Mvc;

namespace SalesUp.MVC.Areas.Admin.ViewComponents;

public class HeaderViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}