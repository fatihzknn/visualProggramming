﻿using InterfaceAbstructDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstructDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
