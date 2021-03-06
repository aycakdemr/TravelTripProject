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
    public class HomePageManager :IHomePageService
    {
        IHomePageDal _homePageDal;

        public HomePageManager(IHomePageDal homePageDal)
        {
            _homePageDal = homePageDal;
        }

        public void Add(HomePage homePage)
        {
            _homePageDal.Insert(homePage);
        }

        public void Delete(int id)
        {
            var value = _homePageDal.Get(x => x.Id == id);
            _homePageDal.Delete(value);
        }

        public List<HomePage> GetAll()
        {
            return _homePageDal.List();
        }

        public void Update(HomePage homePage)
        {
            _homePageDal.Update(homePage);
        }
    }
}
