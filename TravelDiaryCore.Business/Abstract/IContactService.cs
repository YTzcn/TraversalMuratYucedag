using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Abstract
{
    internal interface IContactService
    {
        List<Contact> GetAll();
        Contact GetById(int Id);
        void Add(Contact contact);
        void Remove(Contact contact);
        void Update(Contact contact);
    }
}
