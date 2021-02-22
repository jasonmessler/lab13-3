using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class HumanPlayer : Player // spec 3-3
    {
        public string Name { get; set; }

        public HumanPlayer(string _name) : base(_name)
        {
            Name = _name;
        }

        public HumanPlayer()
        {

        }

        public override RPS GenerateRPS()
        {
            string weaponChoice;

            while (true)
            {
                Console.Write($"Welcome, Honorable {Name}- Choose your weapon: (R) for rock, (P) for paper, (S) for scissors: ");
                weaponChoice = Console.ReadLine();

                switch (weaponChoice)
                {
                    case "R":
                        return RPS.Rock;
                    case "r":
                        return RPS.Rock;
                    case "S":
                        return RPS.Scissors;
                    case "s":
                        return RPS.Scissors;
                    case "P":
                        return RPS.Paper;
                    case "p":
                        return RPS.Paper;
                    default:
                        Console.WriteLine("Invalid Entry- try again!"); //spec 5
                        break;
                }
            }
        }
    }
}
