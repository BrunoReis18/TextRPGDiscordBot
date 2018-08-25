using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPGBot
{
    class Dice
    {

        private static Random rndDice;

        static Dice()
        {
            rndDice = new Random();
        }

        public int Roll(int Sides)
        {

            return rndDice.Next(1, Sides);
            
        }
    }
}
