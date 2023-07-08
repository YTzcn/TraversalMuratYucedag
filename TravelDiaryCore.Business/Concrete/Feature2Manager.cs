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
    public class Feature2Manager : IFeature2Service
    {
        private readonly IFeature2Dal _feature2Dal;
        public Feature2Manager(IFeature2Dal feature2Dal)
        {
                _feature2Dal = feature2Dal;
        }

        public void Add(Feature2 feature2)
        {
            _feature2Dal.Add(feature2);
        }

        public List<Feature2> GetAll()
        {
            return _feature2Dal.GetAll();
        }

        public Feature2 GetById(int Id)
        {
            return _feature2Dal.GetById(x=>x.Feature2Id == Id);
        }

        public void Remove(Feature2 feature2)
        {
            _feature2Dal.Delete(feature2);
        }

        public void Update(Feature2 feature2)
        {
            _feature2Dal.Update(feature2);
        }
    }
}
