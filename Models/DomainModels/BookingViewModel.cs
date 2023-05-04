using System;
namespace HealthFitnessBookingSystem.WebApp.Models.DomainModels
{
    public class BookingViewModel
    {
        public int Id { get; set; }
        public DateTime DateAndTime { get; set; }

        // Foreign keys
        public int ServiceProviderId { get; set; }
        public int ClientId { get; set; }

        // Navigation properties for related entities
        public virtual ServiceProviderViewModel ServiceProvider { get; set; }
        public virtual ClientViewModel Client { get; set; }
    }
}
