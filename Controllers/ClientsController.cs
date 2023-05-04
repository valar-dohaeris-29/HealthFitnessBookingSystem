using Microsoft.AspNetCore.Mvc;
using HealthFitnessBookingSystem.WebApp.Models;
namespace HealthFitnessBookingSystem.WebApp.Controllers
{
    public class ClientsController : Controller
    {
        // Add your data access layer (e.g., DbContext or Repository)

        public IActionResult Index()
        {
            // List available services for the client
            return View();
        }

        public IActionResult BookService(int id)
        {
            // Book a service for the client
            return View();
        }

        public IActionResult BookingConfirmation(int id)
        {
            // Show booking confirmation for the client
            return View();
        }
    }
}
