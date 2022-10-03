using assignment_3.Data;
using assignment_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace assignment_3.Controllers;

public class GuestbookController : Controller
{
    private readonly ApplicationDbContext _database;

    public GuestbookController(ApplicationDbContext database)
    {
        this._database = database;
    }

    public IActionResult Index()
    {
        var guests = _database.Guests.ToList();
        return View(guests);
    }
    
    public IActionResult Add()
    {
        return View();
    }
    
    public IActionResult Insert(string? name, string? title, string? message)
    {
        _database.Guests.Add(new Guest{Name=name, Title=title, Message=message});
        _database.SaveChanges();
        return Redirect("/");
    }
    
}