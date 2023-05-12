namespace HealthFitnessBookingSystem.WebApp.Models.DBModels
{
    public class Service
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public ServiceProviders ServiceProvider { get; set; }
    }
}
