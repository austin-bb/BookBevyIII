using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookBevyIII.Models;

namespace BookBevyIII.Controllers;

public class BooksController : Controller
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

    public BooksController(BookBevyContext context)
    {
      _context = context;
    }

    // [HttpGet("/Books/Dashboard")]
    // public IActionResult Dashboard()
    // {
      
    // }
}