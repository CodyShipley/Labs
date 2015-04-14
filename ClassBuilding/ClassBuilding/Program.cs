using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBuilding
{
    class Program
    {
        static void Main(string[] args)
        {

            var product = new Product();
            product.Name = "OXYCLEAN";
            product.Price = 0;

            Console.WriteLine("Billy Mays Here! Today I am selling " + product.Name + " for only " + product.Price + "!");
            Console.ReadLine();
        }
    }
}
