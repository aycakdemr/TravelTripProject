using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager:IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void Delete(int id)
        {
            var value = _contactDal.Get(x => x.Id == id);
            _contactDal.Delete(value);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.List();
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
