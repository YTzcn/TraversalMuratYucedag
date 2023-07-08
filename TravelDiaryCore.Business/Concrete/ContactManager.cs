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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact GetById(int Id)
        {
            return _contactDal.GetById(x => x.ContactId == Id);
        }

        public void Remove(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
