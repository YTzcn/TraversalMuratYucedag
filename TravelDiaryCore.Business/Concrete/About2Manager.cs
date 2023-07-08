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
    public class About2Manager : IAbout2Service
    {
        private readonly IAbout2Dal _about2Dal;
        public About2Manager(IAbout2Dal about2Dal)
        {
            _about2Dal = about2Dal;
        }
        public void Add(About2 about2)
        {
            _about2Dal.Add(about2);
        }

        public List<About2> GetAll()
        {
            return _about2Dal.GetAll();
        }

        public About2 GetById(int Id)
        {
            return _about2Dal.GetById(x => x.About2Id == Id);
        }

        public void Remove(About2 about2)
        {
             _about2Dal.Delete(about2);
        }

        public void Update(About2 about2)
        {
            _about2Dal.Update(about2);
        }
    }
}
