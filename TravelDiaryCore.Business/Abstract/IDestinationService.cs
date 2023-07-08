using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Abstract
{
    public interface IDestinationService
    {

        List<Destination> GetAll();
        Destination GetById(int Id);
        void Add(Destination destination);
        void Remove(Destination destination);
        void Update(Destination destination);
    }
}
