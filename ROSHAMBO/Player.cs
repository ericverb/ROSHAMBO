using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSHAMBO
{
    public abstract class Player
    {
        public string Name { get; set; }
        public Roshambo Roshambo { get; set; }

        protected Player(string name)
        {
            Name = name;
        }

        public abstract Roshambo GenerateRoshambo();
    }
}