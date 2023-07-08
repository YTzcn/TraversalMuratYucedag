using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Abstract
{
    public interface IAboutService
    {
        List<About> GetAll();
        About GetById(int Id);
        void Add(About about);
        void Remove(About about);
        void Update(About about);
    }
}
