using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesUp.Business.Abstract;
using SalesUp.Entity.Identity;
using SalesUp.Shared.ViewModels;

namespace SalesUp.MVC.Areas.Customer.Controllers;

[Authorize(Roles = "Customer")]
[Area("Customer")]
public class MessageController : Controller
{
    private readonly IMessageService _messageManager;
    private readonly UserManager<User> _userManager;
    private readonly INotyfService _notyfManager;

    public MessageController(INotyfService notyfManager, UserManager<User> userManager, IMessageService messageManager)
    {
        _notyfManager = notyfManager;
        _userManager = userManager;
        _messageManager = messageManager;
    }

    public async Task<IActionResult> Index()
    {
        var userId = _userManager.GetUserId(User);
        var response = await _messageManager.GetAllReceivedMessageAsync(userId);
        var messages = response.Data ?? new List<MessageViewModel>();
        return View(messages);
    }

    public async Task<IActionResult> NewMessage()
    {
        var users = await _userManager.Users.ToListAsync();
        List<SelectListItem> userSelectList = users.Select(x => new SelectListItem
        {
            Text = x.UserName,
            Value = x.Id
        }).ToList();
        
        MessageViewModel model = new MessageViewModel
        {
            UserList = userSelectList
        };
        return View(model);
    }
    
    [HttpPost]
    public async Task<IActionResult> NewMessage(MessageViewModel model)
    {
        var toUser = await _userManager.FindByIdAsync(model.ToId);
        model.ToName = toUser.UserName;
     
        
        var fromUser = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
        model.FromId = fromUser.Id;
        model.FromName = fromUser.UserName;
   
        
        if (model.ReplyText != null)
        {
            model.Text = model.ReplyText;

        }
        var result = await _messageManager.CreateAsync(model);
        if (result.IsSucceeded)
            _notyfManager.Success("Mesaj başarıyla gönderildi.");
        else
            _notyfManager.Error("Mesaj gönderilemedi.");
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> ReadMessage(int id)
    {
        var result = await _messageManager.GetByIdAsync(id);
        var message = result.Data;
        await _messageManager.MakeRead(id);
        return View(message);
    }
    
}