using System;

namespace Lab1
{
    class Program
    {
        static void Main (/*string[] args*/)
        {

            Console.WriteLine ("You in the bridge of a war ship make your way up to the deck");
            room1 (); // start 

        }


       // starting room
        static void room1 ()
        {
            currentRoom = "you are in the Bridge";

            direction input = HandleCommand (); //get command from user
            switch (input)
            {
                case direction.north: 
                room3 ();   // move player 

                break;

                case direction.east:
                room2 ();

                break;

                case direction.south:
                Console.WriteLine ("   **No exit you hit the wall**");
                room1 ();

                break;

                case direction.west:
                room4 ();

                break;

            }
        }


        static void room2 ()
        {
            currentRoom = "you are in the Navigation Room";


            direction input = HandleCommand ();
            switch (input)
            {
                case direction.north:

                Console.WriteLine ("   **No exit you hit the wall**");
                room2 ();

                break;

                case direction.east:

                room5 ();

                break;

                case direction.south:
                room6 ();

                break;

                case direction.west:
                room1 ();

                break;

            }


        }

        static void room3 ()
        {
            currentRoom = "you are in the captains cabin";

            direction input = HandleCommand ();
            switch (input)
            {
                case direction.north:
                Console.WriteLine ("   **No exit you hit the wall**");
                room3 ();

                break;

                case direction.east:
                Console.WriteLine ("   **No exit you hit the wall**");
                room3 ();

                break;

                case direction.south:
                room1 ();

                break;

                case direction.west:

                room11 ();
                break;

            }





        }

        static void room4 ()
        {
            currentRoom = "you are in the Gun Room";
            direction input = HandleCommand ();
            switch (input)
            {
                case direction.north:
                room11 ();

                break;

                case direction.east:
                room1 ();

                break;

                case direction.south:
                room8 ();

                break;

                case direction.west:
                room10 ();

                break;

            }

        }

        static void room5 ()
        {
            currentRoom = "you are in the crew's cabin";

            direction input = HandleCommand ();
            switch (input)
            {
                case direction.north:
                Console.WriteLine ("   **No exit you hit the wall**");
                room5 ();

                break;

                case direction.east:
                Console.WriteLine ("   **No exit you hit the wall**");
                room5 ();

                break;

                case direction.south:
                Console.WriteLine ("   **No exit you hit the wall**");
                room5 ();

                break;

                case direction.west:
                room2 ();

                break;

            }

        }

        static void room6 ()
        {
            currentRoom = "you are in the combat info center";

            direction input = HandleCommand ();
            switch (input)
            {
                case direction.north:
                room2 ();

                break;

                case direction.east:
                Console.WriteLine ("   **No exit you hit the wall**");
                room6 ();

                break;

                case direction.south:
                Console.WriteLine ("   **No exit you hit the wall**");
                room6 ();

                break;

                case direction.west:
                room7 ();

                break;

            }

        }

        static void room7 ()
        {
            currentRoom = "you are in the cargo hold";

            direction input = HandleCommand ();
            switch (input)
            {
                case direction.north:
                Console.WriteLine ("   **No exit you hit the wall**");
                room7 ();

                break;

                case direction.east:
                room6 ();

                break;

                case direction.south:
                room12 ();

                break;

                case direction.west:
                Console.WriteLine ("   **No exit you hit the wall**");
                room7 ();

                break;

            }


        }

        static void room8 ()
        {
            currentRoom = "you are in the kitchen";

            direction input = HandleCommand ();
            switch (input)
            {
                case direction.north:
                room4 ();

                break;

                case direction.east:
                Console.WriteLine ("No exit you hit the wall");
                room8 ();

                break;

                case direction.south:
                Console.WriteLine ("   **No exit you hit the wall**");
                room8 ();

                break;

                case direction.west:
                room9 ();

                break;

            }

        }
        static void room9 ()
        {
            currentRoom = "you are in the engine room";

            direction input = HandleCommand ();
            switch (input)
            {
                case direction.north:
                room10 ();

                break;

                case direction.east:
                room8 ();

                break;

                case direction.south:
                Console.WriteLine ("   **No exit you hit the wall**");
                room9 ();

                break;

                case direction.west:
                Console.WriteLine ("   **No exit you hit the wall**");
                room9 ();

                break;

            }

        }

        static void room10 ()
        {
            currentRoom = "you are in the sick bay";

            direction input = HandleCommand ();
            switch (input)
            {
                case direction.north:
                Console.WriteLine ("   **No exit you hit the wall**");
                room10 ();

                break;

                case direction.east:
                room4 ();

                break;

                case direction.south:
                room9 ();

                break;

                case direction.west:
                Console.WriteLine ("   **No exit you hit the wall**");
                room10 ();

                break;

            }

        }

        static void room11 ()
        {
            currentRoom = "you are in the ward room";

            direction input = HandleCommand ();
            switch (input)
            {
                case direction.north:
                Console.WriteLine ("   **No exit you hit the wall**");
                room11 ();

                break;

                case direction.east:
                room3 ();

                break;

                case direction.south:
                room4 ();

                break;

                case direction.west:
                Console.WriteLine ("   **No exit you hit the wall**"); 
                room11 ();

                break;

            }

        }

        static void room12 ()
        {
            Console.WriteLine ("you reached the deck");

            Console.WriteLine (" Congraturations YOU WON ");
            Environment.Exit (0);


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
            // display the controls
            string input;
            Console.WriteLine ("Move commands");

            Console.WriteLine ("\tF)orward");
            Console.WriteLine ("\tB)ackward");
            Console.WriteLine ("\tL)eft");
            Console.WriteLine ("\tR)ight");

            Console.WriteLine ("\nTurn commands")
                ;
            Console.WriteLine ("\tTurn left");
            Console.WriteLine ("\tTurn right");
            Console.WriteLine ("\tTurn around");

            Console.WriteLine ("Q)quit");

            //get the command
            Console.Write ("Enter a command: ");
            input= Console.ReadLine ();
            Command command = ParseCommand (input);




            return command;
        }

        static direction HandleCommand ()
        {
            int currentd = 0; // current direction the player is facing 
            direction results = 0;

            var quit = false;

            while (!quit)
            {
                // display direction the player is facing
                Console.WriteLine ();
                Console.WriteLine (currentRoom +" facing " + currentDirection);
                Console.WriteLine ();

                // get input from user
                Command command = GetCommand ();
                Console.WriteLine ("********************************************");
                Console.WriteLine ();

                //display error if command is not recognized
                while (command == Command.empty)
                {
                    Console.WriteLine ("  **Invalid command Try again!**");
                    Console.WriteLine ();
                    command = GetCommand ();

                }

                //verify quit command
                if (command == Command.Quit)
                {
                    string input;
                    Console.WriteLine ("Are you shure you want to quit?");
                    Console.Write ("Enter Y or N: ");
                    input = Console.ReadLine ();
                    if (input == "y")
                    {
                        Environment.Exit (0);
                    } else
                        HandleCommand ();

                }


                // if the user enters a turn command the direction the player is currently facing is updated
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


                } else
                {
                    // return direction of the room the player should move.

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
         
            return results;
        }


        static direction currentDirection = direction.north;
        static string currentRoom;
    }


}
