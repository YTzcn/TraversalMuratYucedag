using Microsoft.AspNetCore.Mvc;
using TravelDiaryCore.Business.Abstract;
using TravelDiaryCore.Business.DependencyResolvers.Ninject;

namespace TravelDiaryCore.MVC.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        private IDestinationService _destinationService; 
        public _PopularDestinations()
        {
            _destinationService = InstanceFactory.GetInstance<IDestinationService>(new BussinesModule());
        }
        public IViewComponentResult Invoke()
        {
            var destinations = _destinationService.GetAll();
            return View(destinations);
        }
    }
}
