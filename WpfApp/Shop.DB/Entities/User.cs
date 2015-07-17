﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DB.Interfaces;

namespace Shop.DB.Entities
{
    public class User : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual bool IsAdmin { get; set; }
    }
}
