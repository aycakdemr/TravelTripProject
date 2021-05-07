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
    public class AdminManager:IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(Admin admin)
        {
            _adminDal.Insert(admin);
        }

        public bool Auth(Admin admin)
        {
           if(_adminDal.Auth(admin))
            {
                return true;
            }
            return false;
        }

        public void Delete(int id)
        {
            var value = _adminDal.Get(x => x.Id == id);
            _adminDal.Delete(value);
        }

        public List<Admin> GetAll()
        {
            return _adminDal.List();
        }

        public void Update(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
