using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        void Add(About about);
        void Delete(int id);
        void Update(About about);
        List<About> GetAll();
    }
}
