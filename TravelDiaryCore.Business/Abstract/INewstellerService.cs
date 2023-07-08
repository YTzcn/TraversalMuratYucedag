using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Abstract
{
    public interface INewstellerService
    {
        List<Newsletter> GetAll();
        Newsletter GetById(int Id);
        void Add(Newsletter newsletter);
        void Remove(Newsletter newsletter);
        void Update(Newsletter newsletter);
    }
}
