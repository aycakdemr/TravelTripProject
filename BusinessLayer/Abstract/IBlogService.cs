using EntityLayer.Concrete;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void Add(Blog blog);
        void Delete(int id);
        void Update(Blog blog);
        List<Blog> GetAll();
        List<Blog> GetById(int id);
        Blog GetBlog(int id);
    }
}
