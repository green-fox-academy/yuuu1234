using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day2
{
    class Pokemon
    {
        public String Name;
        public String Type;
        public String EffectiveAgainst;

        public Pokemon(String name, String type, String effectiveAgainst)
        {
            Name = name;
            Type = type;
            EffectiveAgainst = effectiveAgainst;
        }

        public bool IsEffectiveAgainst(Pokemon anotherPokemon)
        {
            return EffectiveAgainst == anotherPokemon.Type;
        }


    }
}
