namespace HealthFitnessBookingSystem.WebApp.Models.DBModels
{
    public class Booking
    {
        public Guid Id { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Client User { get; set; }
        public Service Service { get; set; }
    }
}
