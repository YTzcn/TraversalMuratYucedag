using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Abstract
{
    public interface IFeatureService
    {
        List<Feature> GetAll();
        Feature GetById(int Id);
        void Add(Feature feature);
        void Remove(Feature feature);
        void Update(Feature feature);
    }
}
