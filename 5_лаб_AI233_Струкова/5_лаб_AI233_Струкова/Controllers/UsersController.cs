using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace _5_лаб_AI233_Струкова.Controllers;
public class UsersController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;

    public UsersController(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }
    
    [Authorize(Roles = "mod")]
    public IActionResult Index()
    {
        var users = _userManager.Users.ToList();
        return View(users);
    }
    
}