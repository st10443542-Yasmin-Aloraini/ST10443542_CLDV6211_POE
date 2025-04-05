using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ST10443542_CLDV6211_POE.Models;

namespace ST10443542_CLDV6211_POE.Controllers;
public class BookingsController : Controller
{
    private readonly EventEaseContext _context;
    private readonly ILogger<BookingsController> _logger;

    public BookingsController(EventEaseContext context, ILogger<BookingsController> logger)
    {
        _context = context;
        _logger = logger;
    }

    // GET: Bookings
    public async Task<IActionResult> Index()
    {
        _logger.LogInformation("Fetching all bookings from the database.");
        var bookings = await _context.Bookings
            .Include(b => b.Event)
            .Include(b => b.Venue)
            .ToListAsync();
        return View(bookings);
    }

    // GET: Bookings/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var booking = await _context.Bookings
            .Include(b => b.Event)
            .Include(b => b.Venue)
            .FirstOrDefaultAsync(m => m.BookingId == id);
        if (booking == null)
        {
            return NotFound();
        }

        return View(booking);
    }
}
