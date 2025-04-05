using Microsoft.Extensions.Logging;
using ST10443542_CLDV6211_POE.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ST10443542_CLDV6211_POE.Models
{
    
        public class Venue
        {
            public int VenueId { get; set; }
            public string VenueName { get; set; }
            public string Location { get; set; }
            public int Capacity { get; set; }
            public string ImageUrl { get; set; }
        }
    
}

