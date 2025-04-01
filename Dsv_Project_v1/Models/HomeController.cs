using Microsoft.AspNetCore.Mvc;

namespace Dsv_Project_v1.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
