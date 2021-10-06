using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        /*
        public void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
        */
        public override void Save(Customer customer)
        {
            //CheckIfRealPerson(customer);
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }

            else
            {
                throw new Exception("Not a valid person");
            }

            
        }

      
    }
}
