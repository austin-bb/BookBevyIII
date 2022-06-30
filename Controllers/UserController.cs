using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookBevyIII.Models;

namespace BookBevyIII.Controllers;

public class UsersController : Controller
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

  public UsersController(BookBevyContext context)
  {
    _context = context;
  }

  [HttpPost("users/register")]
  public IActionResult Register(User newUser)
  {
    return View("Book", "Home");
  }
}