using HealthFitnessBookingSystem.WebApp.Enums;

namespace HealthFitnessBookingSystem.WebApp.Models.DBModels
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserRoles Role { get; set; }
    }
}
