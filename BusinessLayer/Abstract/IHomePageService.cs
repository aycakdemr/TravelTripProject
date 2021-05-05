using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHomePageService
    {
        void Add(HomePage homePage);
        void Delete(HomePage homePage);
        void Update(HomePage homePage);
        List<HomePage> GetAll();
    }
}
