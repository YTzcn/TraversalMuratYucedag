using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Abstract
{
    public interface ISubAboutService
    {
        List<SubAbout> GetAll();
        SubAbout GetById(int Id);
        void Add(SubAbout subAbout);
        void Remove(SubAbout subAbout);
        void Update(SubAbout subAbout);
    }
}
