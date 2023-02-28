using ChayBiShop94.DataAccess.Data;
using ChayBiShop94.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using Microsoft.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace ChayBiShop94.Web.Controllers
{
    public class CityController : Controller
    {

        private readonly AppDbContext _context;

        public CityController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<City> Cities;
            Cities = _context.Cities.ToList();
            return View(Cities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            City city = new City();
            ViewBag.Countries = GetCountries();
            return View(city);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(City city)
        {
            city.Id = GuidUtil.GenerateComb();
            city.CountryId = GuidUtil.GenerateComb();
            _context.Add(city);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public IActionResult Details(Guid Id)
        {
            City City = _context.Cities
              .Where(c => c.Id == Id).FirstOrDefault();

            return View(City);
        }

        [HttpGet]
        public IActionResult Edit(Guid Id)
        {
            City City = _context.Cities
              .Where(c => c.Id == Id).FirstOrDefault();

            ViewBag.Countries = GetCountries();

            return View(City);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Edit(City City)
        {
            _context.Attach(City);
            _context.Entry(City).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Delete(Guid Id)
        {
            City City = _context.Cities
              .Where(c => c.Id == Id).FirstOrDefault();

            return View(City);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Delete(City City)
        {
            _context.Attach(City);
            _context.Entry(City).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        private List<SelectListItem> GetCountries()
        {
            var lstCountries = new List<SelectListItem>();

            List<Country> Countries = _context.Countries.ToList();

            lstCountries = Countries.Select(ct => new SelectListItem()
            {
                Value = ct.Id.ToString(),
                Text = ct.Name
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select Country----"
            };

            lstCountries.Insert(0, defItem);

            return lstCountries;
        }
      
    }
}
