using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ST10443542_CLDV6211_POE.Models;


namespace ST10443542_CLDV6211_POE.Controllers;

public class EventsController : Controller
{
    private readonly EventEaseContext _context;
    private readonly ILogger<EventsController> _logger;

    public EventsController(EventEaseContext context, ILogger<EventsController> logger)
    {
        _context = context;
        _logger = logger;
    }

    // GET: Events
    public async Task<IActionResult> Index()
    {
        _logger.LogInformation("Fetching all events from the database.");
        var events = await _context.Events.Include(e => e.Venue).ToListAsync();
        return View(events);
    }

    // GET: Events/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var evnt = await _context.Events
            .Include(e => e.Venue)
            .FirstOrDefaultAsync(m => m.EventId == id);
        if (evnt == null)
        {
            return NotFound();
        }

        return View(evnt);
    }
}