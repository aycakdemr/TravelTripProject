using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager:IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void Delete(int id)
        {
            var value = _blogDal.Get(x=>x.Id == id);
            _blogDal.Delete(value);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.List();
        }

        public List<Blog> GetById(int id)
        {
            return _blogDal.List(x => x.Id == id);
        }
        public Blog GetBlog(int id)
        {
            return _blogDal.Get(x=>x.Id ==id);
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
