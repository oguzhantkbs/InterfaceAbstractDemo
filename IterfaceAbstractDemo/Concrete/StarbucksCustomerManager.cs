using IterfaceAbstractDemo.Abstract;
using IterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager 
    {
        readonly ICustomerCheckService _checkService;
         
        public StarbucksCustomerManager(ICustomerCheckService checkService)
        {
            _checkService = checkService;
        }

        public override void Save(Customer customer)
        {
            if (_checkService.CheckIfRealPerson(customer))
            {
            base.Save(customer); 
            }
            else
            {
                throw new Exception("Not a valid Person");
            }
        }

       
    }
}
