using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Abstract
{
    public interface IAbout2Service
    {
        List<About2> GetAll();
        About2 GetById(int Id);
        void Add(About2 about2);
        void Remove(About2 about2);
        void Update(About2 about2);
    }
}
