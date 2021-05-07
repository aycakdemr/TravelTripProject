using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Delete(int id);
        void Update(Comment comment);
        List<Comment> GetAll();
        List<Comment> GetById(int id);
        Comment GetComment(int id);
    }
}
