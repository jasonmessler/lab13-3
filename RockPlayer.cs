using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    class RockPlayer : Player  //spec 3-1
    {
        public string Name { get; set; }
        public RockPlayer()
        {
            Name = "Frank Dux";
        }

        public override RPS GenerateRPS()
        {
            return RPS.Rock;
        }
    }
}
