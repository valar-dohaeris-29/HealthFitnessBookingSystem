using HealthFitnessBookingSystem.WebApp.Models.DBModels;

namespace HealthFitnessBookingSystem.WebApp.Models.DomainModels
{
    public class ServiceViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ServiceDescription { get; set; }
        public decimal Rate { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}
