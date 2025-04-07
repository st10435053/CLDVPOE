using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EventEaseApp.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        [ForeignKey("Event")]
        public int EventId { get; set; }

        
        public Event? Event { get; set; }

        [Required]
        public int VenueId { get; set; }

        // Specify the foreign key property explicitly
        [ForeignKey("VenueId")]
        public Venue? Venue { get; set; }

        [Required]     
        [DataType(DataType.Date)]
 public DateTime BookingDate { get; set; }
    } 
}
