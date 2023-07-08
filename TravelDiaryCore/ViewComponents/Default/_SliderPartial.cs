using Microsoft.AspNetCore.Mvc;

namespace TravelDiaryCore.MVC.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
