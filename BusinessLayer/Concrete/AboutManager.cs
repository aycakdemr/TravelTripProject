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
    public class AboutManager:IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About about)
        {
            _aboutDal.Insert(about);
        }

        public void Delete(int id)
        {
            var value = _aboutDal.Get(x => x.Id == id);
            _aboutDal.Delete(value);
        }

        public List<About> GetAll()
        {
            return _aboutDal.List();
        }

        public void Update(About about)
        {
            _aboutDal.Update(about);
        }
    }
}
