using Microsoft.AspNetCore.Mvc;

namespace HotelBookingSystem.Server.Controllers
{
    public class HomeBookingSystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
