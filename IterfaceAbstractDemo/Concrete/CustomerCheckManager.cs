using IterfaceAbstractDemo.Abstract;
using IterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
           
            //Mernis Controls
           return true;
        }
    }
}
