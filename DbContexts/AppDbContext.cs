using Microsoft.EntityFrameworkCore;
using HealthFitnessBookingSystem.WebApp.Models.DBModels;


namespace HealthFitnessBookingSystem.WebApp.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ServiceProviders> ServiceProviders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
