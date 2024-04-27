using Asp_Database.Data;
using Asp_Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Database.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    //ViewData["name"] = "Semed";
        //    //ViewBag.name = "Tunzale";
        //      TempData["name"] = "Tunzale";
        //      return RedirectToAction(nameof(Detail));
        //}
        //public IActionResult Detail()
        //{
        //    //ViewData["name"] = "Semed";

        //    return View();
        //}
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
          _context=context;
        }

        //public IActionResult Index()
        //{
        //    var sliders=GetSliders();

        //    return View(sliders);
        //}

        //private List<Slider> GetSliders()
        //{
        //    return new List<Slider>
        //    {
        //        new Slider
        //        {
        //            Id = 1,
        //            Title="Tofiq",
        //            Description="Haci Tofiq"

        //        },

        //        new Slider
        //        {
        //            Id = 2,
        //            Title="Omer",
        //            Description="Omer Xeyyam"

        //        },
        //    };
        //}


        public  async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }
    }
}
