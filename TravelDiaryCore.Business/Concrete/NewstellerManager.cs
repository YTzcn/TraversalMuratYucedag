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
    public class NewstellerManager : INewstellerService
    {
        private readonly INewstellerDal _newstellerDal;
        public NewstellerManager(INewstellerDal newstellerDal)
        {
            _newstellerDal = newstellerDal;
        }

        public void Add(Newsletter newsletter)
        {
            _newstellerDal.Add(newsletter);
        }

        public List<Newsletter> GetAll()
        {
            return _newstellerDal.GetAll();
        }

        public Newsletter GetById(int Id)
        {
            return _newstellerDal.GetById(x => x.NewsletterId == Id);
        }

        public void Remove(Newsletter newsletter)
        {
            _newstellerDal.Delete(newsletter);
        }

        public void Update(Newsletter newsletter)
        {
            _newstellerDal.Update(newsletter);
        }
    }
}
