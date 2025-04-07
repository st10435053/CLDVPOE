using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EventEaseApp.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        [StringLength(200)]
        public string EventDescription { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        [Required]
        [ForeignKey("Venue")]
        public int VenueId { get; set; }
        
        public Venue? Venue { get; set; }
    }
}
