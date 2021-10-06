using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    
    {
        public int Id { get; set; }
        private string _firtName;
        public string FirstName { get; set; }

        /*
                public string FirstName { 
                    get {return "Mr."+ _firtName;} 
                    set {_firtName = value;} 
                }
        */

        public string LastName { get; set; }
        public string City { get; set; }


    }
}
