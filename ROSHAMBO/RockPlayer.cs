using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSHAMBO
{
    public class RockPlayer : Player
    {
        public RockPlayer(string name) : base( name)
        {
            Name = name;
        }


        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}