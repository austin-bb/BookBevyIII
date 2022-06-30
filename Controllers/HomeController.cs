using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookBevyIII.Models;

namespace BookBevyIII.Controllers;

public class HomeController : Controller
{
    private BookBevyContext _context;

    private int? uid 
    {
      get
      {
        return HttpContext.Session.GetInt32("UserId");
      }
    }

    private bool loggedIn
    {
      get
      {
        return uid != null;
      }
    }

    public HomeController(BookBevyContext context)
    {
      _context = context;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
