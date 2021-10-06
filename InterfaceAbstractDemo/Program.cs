using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer
            {
                Id = 1,
                FirstName = "Alper",
                LastName = "Bayram",
                DateOfBirth = new DateTime(1993, 6, 5),
                NationalityId = "59083306486"
            }
            ); ;


        }


    }

}
