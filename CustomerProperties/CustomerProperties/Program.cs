using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProperties
{
    class Program
    {
        static void Main(string[] args)
        {

            var Sally = new Customer();
            var Mike = new Customer();

            Sally.FirstName = "Sally";
            Sally.LastName = "Williams";
            Sally.BillingAddress.City = "Shreveport";
            Sally
         



            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
