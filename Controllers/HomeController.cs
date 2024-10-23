using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aafeben.Models;
using Microsoft.Extensions.Localization;

namespace aafeben.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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

    public IActionResult Login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
