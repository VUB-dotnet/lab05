using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RepairShop.Models;

namespace RepairShop.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var ticketCounter = new TicketCounter
        {
            ActiveCount = _context.Ticket.Count(t => t.Completed == false),
            CompletedCount = _context.Ticket.Count(t => t.Completed)
        };
        return View(ticketCounter);
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
