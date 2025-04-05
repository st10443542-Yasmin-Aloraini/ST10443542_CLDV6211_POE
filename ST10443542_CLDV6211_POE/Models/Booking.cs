using ST10443542_CLDV6211_POE.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ST10443542_CLDV6211_POE.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        // Foreign Keys
        public int EventId { get; set; }
        public int VenueId { get; set; }

        // Navigation Properties
        public Event Event { get; set; }
        public Venue Venue { get; set; }
    }
}