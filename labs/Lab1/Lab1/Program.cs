using System;

namespace Lab1
{
    class Program
    {
        static void Main(/*string[] args*/)
        {

            room1 ();
            
            //while(command != "quit")
            //{
            //    HandleCommand ();
            //}
          
            //string test;
           // Room1 ();




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

        // room1
        static void room1()
        {
            currentRoom = "you are in room 1";
           

            var exit = false;
            while (!exit)
            {

                direction input = HandleCommand ();
                switch (input)
                {
                    case direction.north:

                    break;

                    case direction.east:
                    room2 ();

                    break;

                    case direction.south:
                    Console.WriteLine ("you hit the wall");

                    break;

                    case direction.west:

                    break;

                }



            }

        }


        static void room2 ()
        {
            currentRoom = "you are in room 2"; 
            var exit = false;
            while (!exit)
            {

                direction input = HandleCommand ();
                switch (input)
                {
                    case direction.north:

                    break;

                    case direction.east:

                    break;

                    case direction.south:
                    Console.WriteLine ("you hit the wall");

                    break;

                    case direction.west:
                    room1 ();

                    break;

                }



            }

        }


        enum Command
        {
           
            MoveForward = 0,
            MoveBackward = 2,
            MoveLeft = -1,
            MoveRight = 1,
            TurnLeft = 3,
            TurnRight,
            TurnAround,
            empty,
            Quit
        }
        
          enum direction
        { 
            
            north = 0,
            east = 1,
            west = 3,
            south = 2,
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
            }
           else if (input == "turn left")
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
            Console.WriteLine ("\nTurn command");
            Console.WriteLine ("\tturn left");
            Console.WriteLine ("\tturn right");
            Console.WriteLine ("\tturn around");
            Console.WriteLine ("Q)quit");


            Console.Write("Enter a command");
           input= Console.ReadLine ();
           Command command = ParseCommand (input);

           


            return command;
        }

        static direction HandleCommand ()
        {
            //direction currentDirection = direction.north;
            int currentd = 0;
            direction results = 0;

            var quit = false;

           


            while (!quit)
            {
                Console.WriteLine ( currentRoom +" facing " + currentDirection);
                Console.WriteLine ();

                Command command = GetCommand ();

                while (command == Command.empty)
                {
                    Console.WriteLine ("Invalid command try again!"); 
                    command = GetCommand ();

                }


                //Command command = GetCommand ();


                if (command == Command.TurnAround || command == Command.TurnLeft || command == Command.TurnRight)
                {
                    int mod;

                    if (command == Command.TurnRight)
                        currentd = 1;
                    if (command == Command.TurnLeft)
                        currentd = -1;
                    if (command == Command.TurnAround)
                        currentd = 2;

                    mod = ((int)currentDirection + currentd + 4) % 4;

                    if (mod == 0)
                        currentDirection = direction.north;
                    else if (mod == 1)
                        currentDirection = direction.east;
                    else if (mod == 2)
                        currentDirection = direction.south;
                    else
                        currentDirection = direction.west;
 

                }else
                {
                    int mod;
                    mod = ((int)currentDirection + (int)command + 4) % 4;

                    if (mod == 0)
                        results = direction.north;
                    else if (mod == 1)
                        results = direction.east;
                    else if (mod == 2)
                        results = direction.south;
                    else if (mod == 3)
                        results = direction.west;
                    return results;


                }

               










            }

















            //Pass the rest back to the room to handle
            return results;
        }













        static string menu2()
        {
            Console.WriteLine ("");

            return "";
        }

        static direction currentDirection = direction.north;
        static string currentRoom;
    }

   
}
