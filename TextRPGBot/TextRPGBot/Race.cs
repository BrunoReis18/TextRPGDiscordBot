using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace TextRPGBot
{
    enum RaceSpecies { 
        [Stats(5,5,5,5,5)] Human, 
        [Stats(,1,1,1,1)] Dwarf,
        [Stats(1,1,1,1,1)] Elf,
        [Stats(1,1,1,1,1)] Sentient,
        [Stats(1,1,1,1,1)] Antling
    }
    
    public static class  Race
    {

        private static Stats GetStats(RaceSpecies p)
        {
            return (Stats)Attribute.GetCustomAttribute(ForValue(p), typeof(Stats));
        }

        private static MemberInfo ForValue(RaceSpecies p)
        {
            return typeof(RaceSpecies).GetField(Enum.GetName(typeof(RaceSpecies), p));
        }

    }

    class Stats: Attribute
    {
    
        internal Stats(uint strength, uint intellengence, uint dexterity, uint vitality, uint willPower)
        {
            this.strength = strength;
            this.intellengence = intellengence;
            this.dexterity = dexterity;
            this.vitality = vitality;
            this.willPower = willPower;
        }

        public uint strength { get; private set; }
        public uint intellengence{ get; private set; }
        public uint dexterity{ get; private set; }
        public uint vitality{ get; private set; }
        public uint willPower{ get; private set; }
    }

  
    

}
