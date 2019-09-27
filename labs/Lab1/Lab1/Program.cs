using System;

namespace Lab1
{
    class Program
    {
        static void Main(/*string[] args*/)
        {

           HandleCommand ();
            
            //while(command != "quit")
            //{
            //    HandleCommand ();
            //}
          
            //string test;
           // Room1 ();




        }

        //static string Room1 ()
        //{
        //    var quit = false;
        //    while(!quit)
        //    {
        //        Console.WriteLine ("you are in room 1\n");
        //        string move = Menu ();
        //        string option;

        //        switch (move)
        //        {
        //            case "move left": Console.WriteLine ("\t hit a wall\n");break;
        //             case "move right": Room2();break;
        //             case "quit":
        //            Console.WriteLine ("are you sure you want to quit?");
        //            Console.WriteLine ("type yes or \"no\"");
        //            option = Console.ReadLine ();
        //            if (option == "yes")
        //                quit = true;
        //            break;

        //        }
        //    } 
        //    return "test";
        //}

        //static void Room2 ()
        //{
        //    var quit = false;
        //    while (!quit)
        //    {
        //        Console.WriteLine ("you are in room 2");
        //        string move = Menu ();
        //        string option;

        //        switch (move)
        //        {
        //            case "move right":
        //            Console.WriteLine ("\thit a wall");
        //            break;
        //            case "move left":
        //            Room1();
        //            break;
        //            case "quit":
        //            Console.WriteLine ("are you sure you want to quit?");
        //            Console.WriteLine ("type yes or \"no\"");
        //            option = Console.ReadLine ();
        //            if (option == "yes")
        //                quit = true;
        //            break;

        //        }
        //    }


        //}
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

        // room1
        static void room1()
        {
            var quit = false;
            while (!quit)
            {

                Command input = HandleCommand ();
                switch (input)
                {
                    //case 

                }



            }

        }


        enum Command
        {
            Quit = 1,
            MoveForward = 0,
            MoveBackward,
            MoveLeft,
            MoveRight,
            TurnLeft,
            TurnRight,
            TurnAround,
            empty,
            
            north,
            east,
            west,
            south,
            direction = Command.east,


        }


        static Command ParseCommand ( string input )
        {
            if (String.IsNullOrEmpty (input))
            {
                Console.WriteLine ("Try again");
                GetCommand ();
            };

            input = input.ToLower ();

            if (String.Compare (input, "f", true) == 0)
            {
                return Command.MoveForward;
            } else if (input == "b")
            {
                return Command.MoveBackward;

            } else if (input == "l")
            {
                return Command.MoveLeft;

            } else if (input == "r")
            {
                return Command.MoveRight;

            } else if (input == "q")
            {
                return Command.Quit;
            } else if (input == "turn left")
                return Command.TurnLeft;
            else if (input == "turn right")
                return Command.TurnRight;
            else if (input == "turn around")
                return Command.TurnAround;






            return Command.empty;
        }

        static Command GetCommand ()
        {
            string input;
            Console.WriteLine ("Move commands");
            Console.WriteLine ("\tF)orward");
            Console.WriteLine ("\tB)ackward");
            Console.WriteLine ("\tF)orward");
            Console.WriteLine ("\tL)eft");
            Console.WriteLine ("\tR)ight");
            Console.WriteLine ("\n\nTurn command");
            Console.WriteLine ("turn left");
            Console.WriteLine ("turn right");
            Console.WriteLine ("turn around");
            Console.WriteLine ("Q)quit");



           input= Console.ReadLine ();
           Command command = ParseCommand (input);

           


            return command;
        }

        //static string GetCommand ()
        //{
        //    string input;
        //    Console.WriteLine ("Move commands");
        //    Console.WriteLine ("\tF)orward");
        //    Console.WriteLine ("\tB)ackward");
        //    Console.WriteLine ("\tF)orward");
        //    Console.WriteLine ("\tL)eft");
        //    Console.WriteLine ("\tR)ight");
        //    Console.WriteLine ("\nTurn command");
        //    Console.WriteLine ("turn left");
        //    Console.WriteLine ("turn right");
        //    Console.WriteLine ("turn around");


        //    Console.WriteLine ("Q)quit");


        //    input= Console.ReadLine ();

        //    //Get input from user
        //    String command = ParseCommand (input);
        //    while(command == "")
        //    {
        //        Console.WriteLine (" no input invalid try again");
        //        GetCommand ();
        //    }
        //    //If valid then return the command otherwise display error and keep prompting
        //    return command;
        //}

        static Command HandleCommand ()
        {
            Command currentDirection = Command.direction;

            var quit = false;
            while (!quit)
            {
                Console.WriteLine ("you are facing " + Command.direction);
                Command command = GetCommand ();

                Console.WriteLine ((int)command);
                Console.WriteLine (command);








            }




                
               

               
            



            




            //Pass the rest back to the room to handle
            return Command.empty;
        }













        static string menu2()
        {
            Console.WriteLine ("");

            return "";
        }
    }

   
}
