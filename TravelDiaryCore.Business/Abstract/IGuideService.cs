using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Abstract
{
    public interface IGuideService
    {
        List<Guide> GetAll();
        Guide GetById(int GuideId);
        List<Guide> GetByName(string key);
        void Add(Guide guide);
        void Remove(Guide guide);
        void Update(Guide guide);
    }
}
