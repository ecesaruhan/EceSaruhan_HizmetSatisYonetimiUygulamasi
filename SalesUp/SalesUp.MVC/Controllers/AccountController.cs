using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SalesUp.Business.Abstract;
using SalesUp.Entity.Identity;
using SalesUp.MVC.EmailServices.Abstract;
using SalesUp.Shared.ViewModels.IdentityModels;

namespace SalesUp.MVC.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<User> _userManager;

    private readonly SignInManager<User> _signInManager;

    private readonly IOrderService _orderManager;

    private readonly IEmailSender _emailSender;

    private readonly INotyfService _notyfService;

    private readonly ISTaskService _staskManager;
    
    // GET
    public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IOrderService orderManager, IEmailSender emailSender, INotyfService notyfService, ISTaskService staskManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _orderManager = orderManager;
        _emailSender = emailSender;
        _notyfService = notyfService;
        _staskManager = staskManager;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
    {
        if (ModelState.IsValid)
        {
            User user = new User
            {
                UserName = registerViewModel.UserName,
                Email = registerViewModel.Email,
                FirstName = registerViewModel.FirstName,
                LastName = registerViewModel.LastName,
                EmailConfirmed = true
            };
            var result = await _userManager.CreateAsync(user, registerViewModel.Password);
            if (result.Succeeded)
            {
                var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var backUrl = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = tokenCode
                });

                await _emailSender.SendEmailAsync(
                    user.Email,
                    "SalesUp Üyelik Onayı",
                    $"<p>MiniShopApp uygulamasına üyeliğinizi onaylamak için aşağıdaki linke tıklayınız.</p><a href='https://localhost:7138{backUrl}'>ONAY LİNKİ</a>"
                );
                return Redirect("~/");
            }
        }

        return View(registerViewModel);
    }

    [HttpGet]
    public IActionResult Login(string returnUrl = null)
    {
        if (returnUrl != null)
        {
            TempData["ReturnUrl"] = returnUrl;
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel loginViewModel)
    {
        if (ModelState.IsValid)
        {
            User user = await _userManager.FindByEmailAsync(loginViewModel.UserName);
            if (user != null)
            {
                await _signInManager.SignOutAsync();

                var isConfirmed = await _userManager.IsEmailConfirmedAsync(user);
                if (!isConfirmed)
                {
                    _notyfService.Warning("Lütfen mailinize gelen onay linkine tıklayarak hesabınızı onaylayınız.");
                    return View(loginViewModel);
                }

                var login = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password,
                    loginViewModel.RememberMe, true);
                var failedAttemptCount = await _userManager.GetAccessFailedCountAsync(user);
                if (login.Succeeded)
                {
                    await _userManager.GetAccessFailedCountAsync(user);
                    await _userManager.ResetAccessFailedCountAsync(user);
                    await _userManager.SetLockoutEndDateAsync(user, null);

                    var returnUrl = TempData["ReturnUrl"]?.ToString();
                    _notyfService.Information("Başarılı bir şekilde giriş yaptınız.");

                    if (!String.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }
                else if (!login.IsLockedOut)
                {
                    var lockoutEndDate = await _userManager.GetLockoutEndDateAsync(user);
                    if (lockoutEndDate != null)
                    {
                        var timeLeft = (lockoutEndDate.Value - DateTime.Now).Seconds;
                        if (timeLeft == _userManager.Options.Lockout.DefaultLockoutTimeSpan.TotalSeconds)
                        {
                            _notyfService.Information($"Hesabınız kilitlenmiştir. Lütfen {lockoutEndDate} zamanından sonra deneyiniz.");
                        }
                    }
                    else
                    {
                        var attempCount = _signInManager.Options.Lockout.MaxFailedAccessAttempts;

                        var accessFailedCount = attempCount - failedAttemptCount;
                        _notyfService.Information($"Kalan deneme hakkınız:{accessFailedCount}");
                    }
                }
                else
                {
                    var lockoutEndDate = await _userManager.GetLockoutEndDateAsync(user);
                    var timeLeft = (lockoutEndDate.Value - DateTime.Now).Seconds;
                    _notyfService.Information($"Hesabınız kilitli. Lütfen {timeLeft} sn sonra tekrar deneyiniz.");
                    return View(loginViewModel);
                }
            }
        }

        return View(loginViewModel);
    }
    
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        TempData["ReturnUrl"] = null;
        _notyfService.Success("Çıkış başarılı, güle güle");
        return Redirect("~/");
    }
    
    public IActionResult AccessDenied()
    {
        return View();
    }
    
       
    public async Task<IActionResult> Profile()
    {
        var userId = _userManager.GetUserId(User);
        var orders = await _orderManager.GetOrdersAsync(userId);
        var user = await _userManager.FindByIdAsync(userId);
                
        UserProfileViewModel userProfileViewModel = new UserProfileViewModel
        {
            User = new UserViewModel
            {
                Id= userId,
                FirstName = user.FirstName,
                LastName= user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                City = user.City,
                Gender = user.Gender,
                DateOfBirth = user.DateofBirth
            },
            Orders = orders
        };
        return View(userProfileViewModel);
    }
    
    [HttpPost]
    public async Task<IActionResult> Profile(UserProfileViewModel userProfileViewModel)
    {
        var userId = _userManager.GetUserId(User);
        var user = await _userManager.FindByIdAsync(userId);
        if (ModelState.IsValid)
        {
            user.FirstName = userProfileViewModel.User.FirstName;
            user.LastName= userProfileViewModel.User.LastName;
            user.Email=userProfileViewModel.User.Email;
            user.City = userProfileViewModel.User.City;
            user.Address = userProfileViewModel.User.Address;
            user.PhoneNumber = userProfileViewModel.User.PhoneNumber;
            user.DateofBirth=userProfileViewModel.User.DateOfBirth;
            user.Gender=userProfileViewModel.User.Gender;
            user.UserName=userProfileViewModel.User.UserName;
                
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                await _userManager.UpdateSecurityStampAsync(user);
                await _signInManager.SignOutAsync();
                await _signInManager.SignInAsync(user, false);
                _notyfService.Success("Profiliniz başarıyla güncellenmiştir");
                return Redirect("~/");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
        userProfileViewModel.Orders = await _orderManager.GetOrdersAsync(userId);
        return View(userProfileViewModel);
    }
    
    public async Task<IActionResult> ChangePassword()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
            var isVerified = await _userManager.CheckPasswordAsync(user, changePasswordViewModel.OldPassword);
            if (isVerified)
            {
                var result = await _userManager.ChangePasswordAsync(user,changePasswordViewModel.OldPassword, changePasswordViewModel.NewPassword);
                if (result.Succeeded)
                {
                    var updateSecurityStampResult = await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignOutAsync();
                    await _signInManager.PasswordSignInAsync(user, changePasswordViewModel.NewPassword, false, false);
                    _notyfService.Success("Şifreniz başarıyla değiştirilmiştir.");
                    return RedirectToAction("Profile");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(changePasswordViewModel);
            }
            _notyfService.Warning("Geçerli şifreniz hatalıdır");
        }
        return View(changePasswordViewModel);
    }
    
    public async Task<IActionResult> ConfirmEmail(string userId, string token)
    {
        if (userId == null || token == null)
        {
            _notyfService.Warning("Bilgilerinizde hata var. Kontrol ediniz.");
            return View();
        }
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            _notyfService.Error("Kullanıcı bilgilerinize ulaşılamadı.");
            return View();
        }
        var result = await _userManager.ConfirmEmailAsync(user, token);
        if(result.Succeeded)
        {
            //Bu kişi onaylı bir user olduğuna göre, bir shoppingcart oluşturuyoruz.
            await _staskManager.InitializeSTaskAsync(userId);
            _notyfService.Information("Hesabınız başarıyla onaylanmıştır.");
            return RedirectToAction("Login");
        }
        _notyfService.Error("Hesabınız onaylanırken bir sorun oluştu, daha sonra tekrar deneyiniz.");
        return View();
    }
    
    public IActionResult ForgotPassword()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> ForgotPassword(string email)
    {
        if(email == null)
        {
            ModelState.AddModelError("", "Mail adresinizi yazınız.");
            return View();
        }
        var user = await _userManager.FindByEmailAsync(email);
        if(user == null)
        {
            ModelState.AddModelError("", "Böyle bir hesap bulunamadı.");
            return View();
        }
        var tokenCode = await _userManager.GeneratePasswordResetTokenAsync(user);
        var backUrl = Url.Action("ResetPassword", "Account", new
        {
            userId = user.Id,
            tokenCode = tokenCode
        });
        var subject = "MiniShopApp Şifre Sıfırlama";
        var htmlMessage = $"<h1>MiniShopApp Şifre Sıfırlama İşlemi</h1>" +
                          $"<p>" +
                          $"Lütfen şifrenizi sıfırlamak için aşağıdaki linke tıklayınız." +
                          $"</p>" +
                          $"<a href='https://localhost:59079{backUrl}'>Şifre Sıfırla</a>";
        await _emailSender.SendEmailAsync(email,subject,htmlMessage);
        return RedirectToAction("Login");
    }
    
    public async Task<IActionResult> ResetPassword(string userId, string tokenCode)
    {
        if(userId==null || tokenCode==null)
        {
            ModelState.AddModelError("", "Bir sorun oluştu");
            return View();
        }
        var user = await _userManager.FindByIdAsync(userId);
        if(user == null)
        {
            ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı");
            return View();
        }
        ResetPasswordViewModel resetPasswordViewModel = new ResetPasswordViewModel
        {
            UserId = userId,
            TokenCode = tokenCode
        };
        return View(resetPasswordViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        var user = await _userManager.FindByIdAsync(resetPasswordViewModel.UserId);
        if (user == null)
        {
            ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı");
            return View(resetPasswordViewModel);
        }
        var result = await _userManager.ResetPasswordAsync(
            user, 
            resetPasswordViewModel.TokenCode, 
            resetPasswordViewModel.Password);
        if (result.Succeeded)
        {
            return RedirectToAction("Login");
        }
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError("", error.Description);
        }
        return View(resetPasswordViewModel);
    }

    
}