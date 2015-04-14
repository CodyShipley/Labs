using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProperties
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
    }


    public class Customer
    {
        public Customer()
        {
            this.BillingAddress = new Address();
            this.ShippingAddress = new Address();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }





    }
};
