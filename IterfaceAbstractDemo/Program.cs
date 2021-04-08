using IterfaceAbstractDemo.Abstract;
using IterfaceAbstractDemo.Concrete;
using IterfaceAbstractDemo.Entities;
using System;

namespace IterfaceAbstractDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Oğuzhan", LastName = "Tekbaş", NationalityId = "12345678912" });
                    
        }
    }
}
