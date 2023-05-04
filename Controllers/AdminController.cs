using Microsoft.AspNetCore.Mvc;
using HealthFitnessBookingSystem.WebApp.Models;

namespace HealthFitnessBookingSystem.WebApp.Controllers
{
    public class AdminController : Controller
    {
        // Add your data access layer (e.g., DbContext or Repository)

        public IActionResult Index()
        {
            // List all service providers
            return View();
        }

        public IActionResult AddServiceProvider()
        {
            // Add a new service provider
            return View();
        }

        public IActionResult DeleteServiceProvider(int id)
        {
            // Delete a service provider
            return View();
        }

        public IActionResult BookServiceForClient(int id)
        {
            // Book a service for a client as an admin
            return View();
        }

    }
}
