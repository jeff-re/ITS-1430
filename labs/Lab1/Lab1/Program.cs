using System;

namespace Lab1
{
    class Program
    {
        static void Main(/*string[] args*/)
        {
          
            string test;
            Room1 ();

        }

        static string Room1 ()
        {
            var quit = false;
            while(!quit)
            {
                Console.WriteLine ("you are in room 1\n");
                string move = Menu ();
                string option;

                switch (move)
                {
                    case "move left": Console.WriteLine ("\t hit a wall\n");break;
                     case "move right": Room2();break;
                     case "quit":
                    Console.WriteLine ("are you sure you want to quit?");
                    Console.WriteLine ("type yes or \"no\"");
                    option = Console.ReadLine ();
                    if (option == "yes")
                        quit = true;
                    break;

                }
            } 
            return "test";
        }

        static void Room2 ()
        {
            var quit = false;
            while (!quit)
            {
                Console.WriteLine ("you are in room 2");
                string move = Menu ();
                string option;

                switch (move)
                {
                    case "move right":
                    Console.WriteLine ("\thit a wall");
                    break;
                    case "move left":
                    Room1();
                    break;
                    case "quit":
                    Console.WriteLine ("are you sure you want to quit?");
                    Console.WriteLine ("type yes or \"no\"");
                    option = Console.ReadLine ();
                    if (option == "yes")
                        quit = true;
                    break;

                }
            }


        }
        static string Menu()
        {
            string input;
            Console.WriteLine ("controls: Type:");
            Console.WriteLine ("\t\tmove left\n" +
                "\t\tmove right,");
            Console.WriteLine ("\t\tquit\n\n");
            input= Console.ReadLine();
            return input;

        }
    }

   
}
