using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            PruductManager pruductManager = new PruductManager();
            pruductManager.Update();
            pruductManager.Add();

            Customer customer = new Customer();
            customer.City = "Denizli";
            customer.Id = 1;
            customer.FirstName = "Alper";
            customer.LastName = "Bayram";

            Customer customer2 = new Customer
            {
                Id = 2,City="Düzce",LastName="Kaya",FirstName="Kerem"
            };

            Console.WriteLine(customer.FirstName);


        }
    }
     
}
 