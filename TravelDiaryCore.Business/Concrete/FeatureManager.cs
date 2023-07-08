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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature feature)
        {
            _featureDal.Add(feature);
        }

        public List<Feature> GetAll()
        {
            return _featureDal.GetAll();
        }

        public Feature GetById(int Id)
        {
            return _featureDal.GetById(x=>x.FeatureId == Id);
        }

        public void Remove(Feature feature)
        {
            _featureDal.Update(feature);
        }

        public void Update(Feature feature)
        {
            _featureDal.Update(feature);
        }
    }
}
