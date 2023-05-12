using HealthFitnessBookingSystem.WebApp.DbContexts;
using Microsoft.AspNetCore.Mvc;
using HealthFitnessBookingSystem.WebApp.Models;
using HealthFitnessBookingSystem.WebApp.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace HealthFitnessBookingSystem.WebApp.Controllers
{
    public class ServiceProvidersController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ServiceProvidersController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var serviceProviders = _dbContext.ServiceProviders
                .Include(sp => sp.Services)
                .Select(sp => new ServiceProviderViewModel
                {
                    Id = sp.Id,
                    Name = sp.Name,
                    ServiceDescription = sp.ServiceDescription,
                    Services = sp.Services.Select(s => new ServiceViewModel
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Duration = s.Duration
                    }).ToList()
                    //CostPerService = sp.Rate,
                    //ServiceDurationInMinutes = (int)sp.Services.First().Duration.TotalMinutes,
                    //AvailableDaysAndHours = sp.AvailableDaysAndHours
                })
                .ToList();

            return View(serviceProviders);
        }

        public IActionResult Details(int id)
        {
            // Show service provider details
            return View();
        }

        public IActionResult Edit(int id)
        {
            // Edit service provider details
            return View();
        }

        public IActionResult ConfirmBooking(int id)
        {
            // Confirm booking for a specific service provider
            return View();
        }
    }
}