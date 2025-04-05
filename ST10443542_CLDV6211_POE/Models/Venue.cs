using Microsoft.Extensions.Logging;
using ST10443542_CLDV6211_POE.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ST10443542_CLDV6211_POE.Models
{
    public class Venue
    {
        public int VenueId { get; set; }

        [Required]
        public string VenueName { get; set; }

        [Required]
        public string Location { get; set; }

        [Range(1, 100000)]
        public int Capacity { get; set; }

        public string ImageUrl { get; set; }

        // Navigation Properties
        public ICollection<Event> Events { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}

