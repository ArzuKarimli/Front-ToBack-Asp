using Microsoft.AspNetCore.Mvc;

namespace Asp_Database.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
