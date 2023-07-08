using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Business.Abstract;
using TravelDiaryCore.DataAccess.Abstract;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void Add(Destination destination)
        {
            _destinationDal.Add(destination);
        }

        public List<Destination> GetAll()
        {
            return _destinationDal.GetAll();
        }
        public Destination GetById(int Id)
        {
            return _destinationDal.GetById(x => x.DestinationId == Id);
        }

        public void Remove(Destination destination)
        {
            _destinationDal.Delete(destination);
        }

        public void Update(Destination destination)
        {
            _destinationDal.Update(destination);
        }

    }
}
