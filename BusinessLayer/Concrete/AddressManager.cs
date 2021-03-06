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
   public class AddressManager:IAddressService
    {
        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        public void Add(Address address)
        {
            _addressDal.Insert(address);
        }

        public void Delete(int id)
        {
            var value = _addressDal.Get(x => x.Id == id);
            _addressDal.Delete(value);
        }

        public List<Address> GetAll()
        {
            return _addressDal.List();
        }


        public void Update(Address address)
        {
            _addressDal.Update(address);
        }
    }
}
