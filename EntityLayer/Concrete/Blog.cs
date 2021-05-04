using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog:IEntity
    {
        public int Id { get; set; }
        public string  Header { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comment> Comments { get; set; }
     }
}
