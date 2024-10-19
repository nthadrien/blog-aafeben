using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aafeben.Models;

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

    [Route("Home/a-propos-de-nous")]
    public IActionResult AProposDeNous ()
    {
        Console.WriteLine("Aprorprorp");
        return View();
    }


    public IActionResult Contacts()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
