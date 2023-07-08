using Microsoft.AspNetCore.Mvc;

namespace TravelDiaryCore.MVC.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
