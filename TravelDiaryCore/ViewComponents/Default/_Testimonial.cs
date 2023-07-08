using Microsoft.AspNetCore.Mvc;
using TravelDiaryCore.Business.Abstract;
using TravelDiaryCore.Business.DependencyResolvers.Ninject;

namespace TravelDiaryCore.MVC.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        private ITestimonialService _testimonialService;
        public _Testimonial()
        {
            _testimonialService = InstanceFactory.GetInstance<ITestimonialService>(new BussinesModule());
        }

        public IViewComponentResult Invoke()
        {
            return View(_testimonialService.GetAll());
        }
    }
}
