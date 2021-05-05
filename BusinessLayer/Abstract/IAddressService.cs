﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAddressService
    {
        void Add(Address address);
        void Delete(Address address);
        void Update(Address address);
        List<Address> GetAll();
    }
}