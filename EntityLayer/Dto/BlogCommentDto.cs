using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dto
{
    public class BlogCommentDto
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Comment> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }

    }
}
