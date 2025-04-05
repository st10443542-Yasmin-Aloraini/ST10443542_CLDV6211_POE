using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ST10443542_CLDV6211_POE.Models;

namespace ST10443542_CLDV6211_POE.Controllers;
public class VenuesController : Controller
{
    private readonly EventEaseContext _context;
    private readonly ILogger<VenuesController> _logger;

    public VenuesController(EventEaseContext context, ILogger<VenuesController> logger)
    {
        _context = context;
        _logger = logger;
    }

    // GET: Venues
    public async Task<IActionResult> Index()
    {
        _logger.LogInformation("Fetching all venues from the database.");
        var venues = await _context.Venues.ToListAsync();
        return View(venues);
    }

    // GET: Venues/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var venue = await _context.Venues
            .FirstOrDefaultAsync(m => m.VenueId == id);
        if (venue == null)
        {
            return NotFound();
        }

        return View(venue);
    }
}