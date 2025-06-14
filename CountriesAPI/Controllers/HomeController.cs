using CountriesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CountriesAPI.Controllers
{
    public class HomeController : Controller
    {
        CountryDbContext _countryDbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,CountryDbContext countryDb)
        {
            _countryDbContext = countryDb;
            _logger = logger;
        }

        public IActionResult Index()
        {
           return View(_countryDbContext.Countries.Include(c => c.Cities).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromForm] Country country)
        {
            country.Id = default;
            _countryDbContext.Countries.Add(country);
            _countryDbContext.SaveChanges();
            return View("Index");

        }
        public IActionResult Delete(int id)
        {
            Country country = _countryDbContext.Countries.FirstOrDefault(c => c.Id == id);
            if (country == null)
            {
                return NotFound();
            }
            _countryDbContext.Countries.Remove(country);
            _countryDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
