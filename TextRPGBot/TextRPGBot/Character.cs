using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPGBot
{
    class Character
    {
        private string charName;
        private UInt32 statStrength;
        private UInt32 statIntelligence;
        private UInt32 statDexterity;
        private UInt32 statVitality;
        private UInt32 statWillPower;

        private RaceSpecies charRace = Race.GetSpeciesByName("Human");

        


        private UInt32 totalHealth;
        private UInt32 totalMana;


        public Character(string name)
        {
            charName = name;

        }

        public UInt32 StatStrength
        {
            get { return statStrength; }
            set { statStrength = value; }
        }
        public UInt32 StatIntelligence
        {
            get { return statIntelligence; }
            set { statIntelligence = value; }
        }
        public UInt32 StatDexterity
        {
            get { return statDexterity; }
            set { statDexterity = value; }
        }
        

    }
}
