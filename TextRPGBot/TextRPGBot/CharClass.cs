using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPGBot
{
    class CharClass
    {

        private enum charClassType
        {
            Warrior,
            Mage,
            Paladin,
            Thief,
            Bard
        }

        private enum Personality
        {

        }

        private UInt32 charClassBaseStr { get; set; }
        private UInt32 charClassBaseInt { get; set; }
        private UInt32 charClassBaseDxt { get; set; }
        private UInt32 charClassBaseHlt { get; set; }



        public CharClass()
        {

        }
    }
}
