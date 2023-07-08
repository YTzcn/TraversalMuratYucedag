using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Abstract
{
    public interface IFeature2Service
    {
        List<Feature2> GetAll();
        Feature2 GetById(int Id);
        void Add(Feature2 feature2);
        void Remove(Feature2 feature2);
        void Update(Feature2 feature2);
    }
}
