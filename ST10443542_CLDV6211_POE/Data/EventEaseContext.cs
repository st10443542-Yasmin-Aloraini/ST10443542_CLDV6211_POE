using Microsoft.EntityFrameworkCore;
using ST10443542_CLDV6211_POE.Models;

public class EventEaseContext : DbContext
{
    // Constructor to pass DbContextOptions to the base class
    public EventEaseContext(DbContextOptions<EventEaseContext> options)
        : base(options)
    {
    }

    // DbSets representing the entities in your database
    public DbSet<Venue> Venues { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Booking> Bookings { get; set; }

    // OnModelCreating method for additional model configuration if needed
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Example of custom configuration for the Venue entity (optional)
        modelBuilder.Entity<Venue>()
            .HasKey(v => v.VenueId); // Primary key configuration for Venue

        modelBuilder.Entity<Event>()
            .HasKey(e => e.EventId); // Primary key configuration for Event

        modelBuilder.Entity<Booking>()
            .HasKey(b => b.BookingId); // Primary key configuration for Booking

    }
}
