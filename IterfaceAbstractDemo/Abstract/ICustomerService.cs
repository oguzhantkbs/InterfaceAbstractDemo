﻿using IterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceAbstractDemo.Abstract
{
   public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
