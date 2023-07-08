using Microsoft.AspNetCore.Mvc;
using TravelDiaryCore.Business.Abstract;
using TravelDiaryCore.Business.DependencyResolvers.Ninject;
using TravelDiaryCore.DataAccess.Abstract;

namespace TravelDiaryCore.MVC.ViewComponents.Default
{
    public class _Statistic : ViewComponent
    {
        private IDestinationService _destinationService;
        private IGuideService _guideService;
        public _Statistic()
        {
            _destinationService = InstanceFactory.GetInstance<IDestinationService>(new BussinesModule());
            _guideService = InstanceFactory.GetInstance<IGuideService>(new BussinesModule());
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.DestCount = _destinationService.GetAll().Count();
            ViewBag.GuideCount= _guideService.GetAll().Count();
            return View();
        }

    }
}
