using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aafeben.Models;
using Microsoft.Extensions.Localization;
using aafeben.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace aafeben.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context )
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Dash()
    {
        return View();
    }

    // [Route("Home/a-propos-de-nous")]
    public IActionResult AProposDeNous ()
    {
        // Create an array of dictionaries
        var Faq = new List<Dictionary<string, object>>();
        return View();
    }

    public IActionResult Projets ()
    {
        return View();
    }

    public IActionResult Projet  ()
    {
        return View();
    }

    public IActionResult Publications ()
    {
        return View();
    }

    public IActionResult Publication  ()
    {
        return View();
    }

    public IActionResult Blogs ()
    {
        return View();
    }

    public IActionResult Blog  ()
    {
        return View();
    }

    public IActionResult Opportunites  ()
    {
        return View();
    }

    public IActionResult Actualites  ()
    {
        var message = HttpContext.Request.PathBase;
        return View();
    }

    public IActionResult Contacts()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login (string username, string password, string ReturnUrl)
    {
        // var user = await _context.Users.FirstOrDefaultAsync(m => m.UserName == username);
        // if (user == null)
        // {
        //     return NotFound();
        // }
        bool user = username == "admin" && password == "admin";
        
        if ( user  )
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username)
                
            };
            var claimsIdentity = new ClaimsIdentity( claims, "Login");
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            return Redirect(ReturnUrl == null ? "Opportunities" : ReturnUrl );

        } else 
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
