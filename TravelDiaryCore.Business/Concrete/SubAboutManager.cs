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
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutDal _subAboutDal;
        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Add(SubAbout subAbout)
        {
            _subAboutDal.Add(subAbout);
        }

        public List<SubAbout> GetAll()
        {
            return _subAboutDal.GetAll();
        }

        public SubAbout GetById(int Id)
        {
            return _subAboutDal.GetById(x => x.SubAboutId == Id);
        }

        public void Remove(SubAbout subAbout)
        {
            _subAboutDal.Delete(subAbout);
        }

        public void Update(SubAbout subAbout)
        {
            _subAboutDal.Update(subAbout);
        }
    }
}
