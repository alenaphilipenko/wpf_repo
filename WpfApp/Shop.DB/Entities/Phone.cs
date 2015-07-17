using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DB.Interfaces;

namespace Shop.DB.Entities
{
    public class Phone : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual int Owner { get; set; }
        public virtual string Type { get; set; }
    }
}
