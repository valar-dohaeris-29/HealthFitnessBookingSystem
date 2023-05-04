using System.Collections.Generic;

namespace HealthFitnessBookingSystem.WebApp.Models.DomainModels
{
    public class ServiceProviderViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ServiceDescription { get; set; }
        public double CostPerService { get; set; }
        public int ServiceDurationInMinutes { get; set; }
        public string AvailableDaysAndHours { get; set; }

        // Navigation property for related bookings
        public virtual ICollection<BookingViewModel> Bookings { get; set; }
    }
}
