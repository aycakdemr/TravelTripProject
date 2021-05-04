using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin :IEntity
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
