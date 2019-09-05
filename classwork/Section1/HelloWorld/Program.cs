﻿/*
 * ITSE 1430
 * Lab 1
 * Me 
 */
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( /*string[] args*/ )
        {
            //Movie data
            //string title;
            //int runLength;
            //int releaseYear;
            //string description;
            //bool haveSeen;

            while (true)
            {
                char input = DisplayMenu ();
                if (input == 'A')
                    AddMovie ();
                else if (input == 'D')
                    DisplayMovie ();
                else if (input == 'Q')
                    break;
            };
        }

        static void AddMovie ()
        {
            //Get title
            Console.Write ("Title: ");
            title = Console.ReadLine ();

            //Get description
            Console.Write ("Description: ");
            description = Console.ReadLine ();

            //Get release year
            releaseYear = ReadInt32 ("Release Year: ");

            //Get run length
            runLength = ReadInt32 ("Run Length (in minutes): ");

            //Get have seen
            hasSeen = ReadBoolean ("Have Seen? ");
        }

        static void DisplayMovie()
        {
            //Title, description, release year, run length, hasSeen
            Console.WriteLine (title);
            Console.WriteLine (description);

            //Formatting strings
            //1) String concat
            Console.WriteLine ("Released " + releaseYear);

            //2) Printf
            //Console.WriteLine("Run time: {0}", runLength);

            //3) String formatting
            var formattedString = String.Format ("Run time: {0}", runLength);
            Console.WriteLine (formattedString);

            Console.WriteLine ("Seen it? " + hasSeen.ToString ());

            //4) String interpolation
            Console.WriteLine ($"Seen it? {hasSeen}");

        }

        static bool ReadBoolean ( string message )
        {
            while (true)
            {
                Console.Write (message);

                string input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                bool result;
                if (Boolean.TryParse (input, out result))
                    return result;

                Console.WriteLine ("Not a boolean");
            };
        }

        static int ReadInt32 ( string message )
        {
            while (true)
            {
                Console.Write (message);

                string input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                //int result;
                //if (Int32.TryParse (input, out result))
                if (Int32.TryParse (input, out int result))
                    return result;

                Console.WriteLine ("Not a number");
            };
        }

        static char DisplayMenu ()
        {
            do
            {
                Console.WriteLine ("A)dd Movie");
                Console.WriteLine ("D)isplay Movie");
                Console.WriteLine ("Q)uit");

                string input = Console.ReadLine ();

                // Lowe case
                input = input.ToLower ();
                //if (input == "A")
                if (String.Compare(input, "a", true)== 0)
                {
                    return 'A';
                } else if (input == "Q")
                {
                    return 'Q';
                } else if (input == "D")
                    return 'D';
                else
                    Console.WriteLine ("Invalid input");

            } while (true);
        }

        private static void DemoLanguage ()
        {
            //TODO: Move this
            string name = "";

            //string if = "";

            //Definitely assigned
            //name = "Bob";
            string name2 = Console.ReadLine ();
            //name2 = Console.ReadLine ();

            name2 = name = "Sue";
            Console.WriteLine (name2);
            Console.WriteLine ("Hello World!");

            //Another block
            //Yet another block

            int hours = 8;
            double payRate = 15.25;

            double totalPay = payRate * hours;

            string fullName = "Fred" + " " + "Jones";

        }

        static void DemoArray ()
        {
            double[] payRates = new double[100];

            // 50th element to 7.25
            payRates[49] = 7.25;

            //Read 89th element into temp variable
            double payRate = payRates[88];

            //Print out the 80th element
            Console.WriteLine (payRates[79]);


            // An empty array
            bool[] ifPassing = new bool[0];

            //Enumerating an array
            for (int index = 0; index < payRates.Length; ++index)
                Console.WriteLine(payRates[index]);

            //Type inferencing
            //string name = "Bob William Smith Jr III";
            var  name = "Bob William Smith Jr III";


            string[] nameParts = name.Split(' ');

        }

        //Don't do this outside lab 1
        static string title;
        static string description;
        static int runLength;
        static int releaseYear;
        static bool hasSeen;


    }
}
