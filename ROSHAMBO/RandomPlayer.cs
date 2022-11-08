﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace ROSHAMBO
{
    public class RandomPlayer : Player
    {
        public RandomPlayer(string name) : base(name)
        {
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            int returnValue = random.Next(1, 3);

            switch (returnValue)
            {
                case 1:
                    return Roshambo.Rock;

                case 2:
                    return Roshambo.Paper;

                default:
                    return Roshambo.Scissors;
            }

        }
    }
}