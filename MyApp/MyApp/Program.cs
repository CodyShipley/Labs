using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Integers(Int,Long,Short) - Whole Numbers
            //Floats, Doubles - Decimals <-- Used for calculations that can be off by a certain ammount. 
            //Decimals - Precise Decimal <-- Used for things like Pricing.


            //var price = 234124214.12;
            //That 0:c <- the 'c' changes to areas currency.
            //var message = String.Format("It cost {0:c} dollars and {1} cents", 23m, 25);

            //Console.WriteLine(message);
            //Console.ReadLine();


            //Regex
            //var isMatch = Regex.IsMatch("applesauce", @"\d+");
            //Console.WriteLine(isMatch);
            //Console.ReadLine();

            //Arrays
            //var random = new Random();

            //var myNews = new string[3]{
            //"Man Just Won A Million Dollars Selling Baby Hair!",
            //"Giraffes Escape From Zoo.. And Become Finance Majors!",
            //"Aliens Visit From Pluto, Arguing That It Is Indeed A Planet"
            //};

            //Console.WriteLine(myNews[random.Next(myNews.Length)]);
            //Console.ReadLine();

            //    Console.WriteLine(Reverse("FrameWork"));
            //    Console.ReadLine();


            //Loops

            



        }

        //}
        //public static string Reverse(string mystring)
        //{
        //    char[] charArray = mystring.ToCharArray();
        //    Array.Reverse(charArray);
        //    return new string(charArray);
        //}

        //static void Main(string[] args)
        //{
        //    var rand = new Random();
        //    var result = rand.Next(10);
        //    Console.WriteLine("The random number is " + result + ".");


        //    if (result > 5)
        //    {
        //        Console.WriteLine("You won!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You lose!");
        //    }




        //     //<summary>
        //     //Date Section     
        //     //</summary>

        //    var getDate = DateTime.Now;
        //    Console.WriteLine(getDate);




        //    var a = 3;
        //    var b = 0;
        //    //Asserts are used so the developer knows their options. Here we are saying we can't divide by zero. If I try to, I will get thrown my error of "B can't be zero"
        //   // Debug.Assert(b != 0, "B Can't Be Zero");
        //    var tax = a / b;

        //    Console.WriteLine(tax);


        //    Console.ReadLine();
        //}
    }
}
