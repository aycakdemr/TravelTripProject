using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        void Add(Admin admin);
        void Delete(int id);
        void Update(Admin admin);
        List<Admin> GetAll();
        Boolean Auth(Admin admin);
    }
}
