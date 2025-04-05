using ST10443542_CLDV6211_POE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ST10443542_CLDV6211_POE.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        public string Description { get; set; }

        // Foreign Key
        public int VenueId { get; set; }

        // Navigation Properties
        public Venue Venue { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}