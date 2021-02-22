using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPS
{
    abstract class Player // spec 2
    {
        private string Name { get; set; }

        public Player(string _name)
        {
            Name = _name;
        }

        public Player()
        {

        }

        public abstract RPS GenerateRPS();
    }
}
