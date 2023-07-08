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
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;
        public GuideManager(IGuideDal guideDal)
        {
                _guideDal = guideDal;
        }
        public void Add(Guide guide)
        {
          _guideDal.Add(guide);
        }

        public List<Guide> GetAll()
        {
            return _guideDal.GetAll();
        }

        public Guide GetById(int GuideId)
        {
            return _guideDal.GetById(x => x.GuidId == GuideId);
        }

        public List<Guide> GetByName(string key)
        {
            return _guideDal.GetAll(x=>x.GuideName.ToLower().Contains(key.ToLower())); 
        }

        public void Remove(Guide guide)
        {
            _guideDal.Delete(guide);
        }

        public void Update(Guide guide)
        {
            _guideDal.Update(guide);
        }
    }
}
