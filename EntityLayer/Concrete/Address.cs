using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Address :IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string OpenAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
    }
}
