using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBuilding
{

    class Mail
    {
        public void Send(string to, string from = "Cody.Shipley@Codercamps.com", string subject = "Official Email", string body = "Read This!")
        {

        }
    }

    class ShoppingCart
    {
        public void AddToCart(params Product[] items)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var cart = new ShoppingCart();

            cart.AddToCart(new Product { Name = "Crayons" }, new Product { Name = "Screwdriver" });

            var burger = new Product
            {
                Name = "Burger",
                Price = 12.33m
            };


            var mail = new Mail();
            mail.Send("CodyBShipley@gmail.com", subject: "I am Hungry");

            
            Console.WriteLine(tax);
            Console.ReadLine();
        }
    }
}
