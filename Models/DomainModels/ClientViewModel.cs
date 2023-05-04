using System.Collections.Generic;

namespace HealthFitnessBookingSystem.WebApp.Models.DomainModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Navigation property for related bookings
        public virtual ICollection<BookingViewModel> Bookings { get; set; }
    }
}
