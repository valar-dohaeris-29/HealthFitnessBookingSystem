namespace HealthFitnessBookingSystem.WebApp.Models.DBModels
{
    public class ServiceProviders
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ServiceDescription { get; set; }
        public decimal Rate { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}
