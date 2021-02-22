using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class RandomPlayer : Player //spec 3-2
    {
        public string Name { get; set; }
        public RandomPlayer()
        {
            Name = "Chong Li";
        }

        public override RPS GenerateRPS()
        {
            var random = new Random();
            RPS randomEnum = (RPS)random.Next(0, 3);
            return randomEnum;
        }
    }
}
