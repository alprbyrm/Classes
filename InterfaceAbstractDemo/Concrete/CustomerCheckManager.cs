using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        //bu sinifi mernis yapisinin alternatifi olarak simule etmek icin kurduk
        public bool CheckIfRealPerson(Customer customer)
        {
            
            return true;
        }
    }
}
