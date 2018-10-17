using System;

public class TicTacToe
{
    //array for positions on board
    static char[] position = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    //chosen spot
    static int spot;
    //holding outcome
    static int outcome = 0;
    //counter to determine which player is going
    static int player = 1;

    public static void Main()
    {
		Console.WriteLine("Tic Tac Toe\n");
        Console.WriteLine("Player 1 is X, Player 2 is O\nEnter a number on the display to choose.\n");
        do
        {
			// showing board state
            Display();

            if (player % 2 != 0)//its player 1
            {
                Console.WriteLine("\nPlayer 1 enter your choice: ");
            }
            else
            {
                Console.WriteLine("\nPlayer 2 enter your choice: ");
            }
            //user input

            while (!int.TryParse(Console.ReadLine(), out spot))
			{
				Console.WriteLine("Invalid option, please enter a number between 1-9: ");
			}

            //checking for correct input
            if (spot < 1 || spot > 9)
            {
                Console.WriteLine("Invalid option, please enter a number between 1-9");
            }
            //making sure the spot isnt already taken
            else if (position[spot] == 'X' || position[spot] == 'O')
            {
                Console.WriteLine("That spot is already taken, please choose a different one");
            }
            else
            {
                if (player % 2 != 0)
                {
                    position[spot] = 'X';
                }
                else
                {
                    position[spot] = 'O';
                }
                player++;
            }
            outcome = CheckScore();
            if (outcome == 1)
            {
                if (player % 2 == 0)
                {
                    Display();
                    Console.WriteLine("Player 1 has Won, press any key to exit");
                    Console.ReadLine();
                }
                else
                {
                    Display();
                    Console.WriteLine("Player 2 has Won, press any key to exit");
                    Console.ReadLine();
                }


            }
            else if (outcome == -1)
            {
                Display();
                Console.WriteLine("Its a draw, press any key to exit");
                Console.ReadLine();
            }

        } while (outcome != 1 && outcome != -1);


    }

    private static int CheckScore()
    {
        //win condition
        if (position[1] == position[2] && position[1] == position[3])
        {
            return 1;
        }
        //win condition
        else if (position[4] == position[5] && position[4] == position[6])
        {
            return 1;
        }
        //win condition
        else if (position[7] == position[8] && position[7] == position[9])
        {
            return 1;
        }
        //win condition
        else if (position[1] == position[4] && position[1] == position[7])
        {
            return 1;
        }
        //win condition
        else if (position[2] == position[5] && position[2] == position[8])
        {
            return 1;
        }
        //win condition
        else if (position[3] == position[6] && position[3] == position[9])
        {
            return 1;
        }
        //win condition
        else if (position[1] == position[5] && position[1] == position[9])
        {
            return 1;
        }
        //win condition
        else if (position[3] == position[5] && position[3] == position[7])
        {
            return 1;
        }
        //draw, all spots are filled 
        else if (position[1] != '1' && position[2] != '2' && position[3] != '3' && position[4] != '4' && position[5] != '5' && position[6] != '6' && position[7] != '7' && position[8] != '8' && position[9] != '9')
        {
            return -1;
        }
        //games still going, no win or draw
        else
        {
            return 0;
        }
    }

    //displays current map status
    private static void Display()
    {
        Console.WriteLine("\n     |     |      ");
        Console.WriteLine(position[1] + "    | " + position[2] + "   | " + position[3]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine(position[4] + "    | " + position[5] + "   | " + position[6]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine(position[7] + "    | " + position[8] + "   | " + position[9]);
        Console.WriteLine("     |     |      ");
    }

}