using Microsoft.AspNetCore.Mvc;
using TravelDiaryCore.Business.Abstract;
using TravelDiaryCore.Business.DependencyResolvers.Ninject;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.MVC.Controllers
{
    public class DestinationController : Controller
    {
        private IDestinationService _destinationService;
        public DestinationController()
        {
            _destinationService = InstanceFactory.GetInstance<IDestinationService>(new BussinesModule());
        }
        public IActionResult Index()
        {
            return View(_destinationService.GetAll());
        }
        [HttpGet]
        public IActionResult DestinationDetails(int Id)
        {
            
            return View(_destinationService.GetById(Id));
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
