using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EventEaseApp.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

        [Required]
        public string VenueName { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public string ImageUrl { get; set; }

    }
}
