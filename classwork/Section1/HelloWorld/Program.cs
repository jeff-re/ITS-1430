/*
 * ITSE 1430
 * Lab 1
 * geofffrey
 */
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( /*string[] args*/ )
        {  
            string name = "";
            //name = "Bob";
            string name2;

            name2 = Console.ReadLine ();
            //string name2;
            //string if = "";

            Console.WriteLine (name2);
            name2 = name = "Sue";

            Console.WriteLine ("Hello World!");

            int hours = 8;
            double payrate = 15.25;

            double totalpay = payrate * hours;
            string fullname = "fred " + "" + "jones";

        }
    }
}
