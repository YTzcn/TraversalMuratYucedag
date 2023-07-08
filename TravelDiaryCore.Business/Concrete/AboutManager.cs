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
    public class AboutManager : IAboutService
    {
        private IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void Add(About about)
        {
            _aboutDal.Add(about);
        }

        public List<About> GetAll()
        {
          return _aboutDal.GetAll();
        }

        public About GetById(int Id)
        {
            return _aboutDal.GetById(x=>x.AboutId == Id);
        }

        public void Remove(About about)
        {
            _aboutDal.Delete(about);
        }

        public void Update(About about)
        {
            _aboutDal.Update(about);
        }
    }
}
