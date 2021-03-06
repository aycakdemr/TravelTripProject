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
    public class CommentManager:ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void Delete(int id)
        {
            var value = _commentDal.Get(x => x.Id == id);
            _commentDal.Delete(value);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.List();
        }

        public List<Comment> GetById(int id)
        {
            return _commentDal.List(x => x.BlogId == id);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }
        public Comment GetComment(int id)
        {
            return _commentDal.Get(x => x.Id == id);
        }
    }
}
