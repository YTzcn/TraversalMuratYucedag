using Microsoft.AspNetCore.Mvc;
using TravelDiaryCore.Business.Abstract;
using TravelDiaryCore.Business.DependencyResolvers.Ninject;

namespace TravelDiaryCore.MVC.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        private ISubAboutService _subAboutService;
        public _SubAbout()
        {
            _subAboutService = InstanceFactory.GetInstance<ISubAboutService>(new BussinesModule());
        }

        public IViewComponentResult Invoke()
        {

            return View(_subAboutService.GetAll());
        }

    }
}
