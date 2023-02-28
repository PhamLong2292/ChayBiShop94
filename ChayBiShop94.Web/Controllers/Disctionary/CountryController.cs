using ChayBiShop94.DataAccess.Data;
using ChayBiShop94.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChayBiShop94.Web.Controllers
{
    public class CountryController : Controller
    {

        private readonly AppDbContext _context;

        public CountryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Country> countries;
            countries = _context.Countries.ToList();
            return View(countries);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Country country = new Country();
            return View(country);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(Country country)
        {
            country.Id = GuidUtil.GenerateComb();         
            _context.Add(country);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(Guid Id)
        {
            Country country = GetCountry(Id);
            return View(country);
        }

        [HttpGet]
        public IActionResult Edit(Guid Id)
        {
            Country country = GetCountry(Id);
            return View(country);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Edit(Country country)
        {
            _context.Attach(country);
            _context.Entry(country).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private Country GetCountry(Guid id)
        {
            Country country;
            country = _context.Countries
             .Where(c => c.Id == id).FirstOrDefault();
            return country;

        }

        [HttpGet]
        public IActionResult Delete(Guid Id)
        {
            Country country = GetCountry(Id);
            return View(country);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Delete(Country country)
        {

            _context.Attach(country);
            _context.Entry(country).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
