using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    public class RPSApp //spec 4
    {
        public void Kumite()
        {
            HumanPlayer player1 = new HumanPlayer();

            Console.WriteLine("Welcome to KUMITE!");
            Console.Write("Enter your name: ");
            player1.Name = Console.ReadLine();

            do
            {
                Player opponent = GetPlayer();

                RPS Fighter1 = player1.GenerateRPS();
                RPS Fighter2 = opponent.GenerateRPS();

                Console.WriteLine(Fighter1);
                Console.WriteLine(Fighter2);

                if (Fighter1 == RPS.Rock && Fighter2 == RPS.Rock)
                {
                    Console.WriteLine("TIE");
                }
                else if (Fighter1 == RPS.Paper && Fighter2 == RPS.Paper)
                {
                    Console.WriteLine("TIE");
                }
                else if (Fighter1 == RPS.Scissors && Fighter2 == RPS.Scissors)
                {
                    Console.WriteLine("TIE");
                }
                else if (Fighter1 == RPS.Paper && Fighter2 == RPS.Rock)
                {
                    Console.WriteLine("VICTORY");
                }
                else if (Fighter1 == RPS.Scissors && Fighter2 == RPS.Paper)
                {
                    Console.WriteLine("VICTORY");
                }
                else if (Fighter1 == RPS.Rock && Fighter2 == RPS.Scissors)
                {
                    Console.WriteLine("VICTORY");
                }
                else if (Fighter1 == RPS.Rock && Fighter2 == RPS.Paper)
                {
                    Console.WriteLine("DEFEAT");
                }
                else if (Fighter1 == RPS.Paper && Fighter2 == RPS.Scissors)
                {
                    Console.WriteLine("DEFEAT");
                }
                else if (Fighter1 == RPS.Scissors && Fighter2 == RPS.Rock)
                {
                    Console.WriteLine("DEFEAT");
                }

            } while (PlayAgain());


            bool PlayAgain()
            {
                string playAgain;
                bool isInvalid;
                do
                {
                    Console.Write("Would you like to avenge your honor? (y/n): ");
                    playAgain = Console.ReadLine().ToLower();

                    isInvalid = playAgain != "y" && playAgain != "n";
                    if (isInvalid)
                    {
                        Console.WriteLine("Invalid Entry- Please enter a 'y' or 'n'!"); //spec 5
                    }
                } while (isInvalid);

                if (playAgain == "n")
                {
                    Console.WriteLine("Sayonara!");
                }
                return playAgain == "y";
            }

            Player GetPlayer()
            {
                do
                {
                    Console.Write("Choose the form of your Destructor! 1 for Frank Dux or 2 for Chong Li: ");
                    string choice = Console.ReadLine().ToLower();

                    switch (choice)
                    {
                        case "1":
                            return new RockPlayer();
                        case "2":
                            return new RandomPlayer();
                        default:
                            Console.WriteLine("Invalid Entry- Try Again");  //spec 5
                            break;
                    }
                } while (true);
            }
        }
    }
}