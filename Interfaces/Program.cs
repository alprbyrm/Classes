using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[] 
            { 
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
             

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Alper", LastName = "Bayram", Adress = "Denizli" });

            Student student = new Student()
            {
                Id = 2,
                FirstName = "Gamze",
                LastName = "Erkan",
                Departmant = "Cocuk Gelisimi"
            };
            //aşağıdaki şekilde eklemeyi kabul etmiyor çünkü manager sınıfında parametre olarak Customer sınıfı istedik 
            // bu yapıyı düzeltmenin en güzel yolu Interface olarak giriş isteriz
            //personManager.Add(student);

            personManager.Add(student);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }


        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Adress { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }

        class PersonManager
        {

            //Kabul olamayan eski yapı 
            /*
                    public void Add(Customer customer)
                    {
                        Console.WriteLine(customer.FirstName);
                    }
                }
            */
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }
} 