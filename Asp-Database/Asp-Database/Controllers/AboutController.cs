using Microsoft.AspNetCore.Mvc;

namespace Asp_Database.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
