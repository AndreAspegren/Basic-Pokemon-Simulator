using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon;

namespace Pokemon
{
    internal class Rival : IHuman_Character
    {
        public string Name { get; set; }
        public int _maxPokemon { get; set; }

        internal Rival(string name, int maxPokemon)
        {
            Name = name;
            _maxPokemon = maxPokemon;
        }

        public void greeting()
        {
            Console.WriteLine("Vær klar til å bli knust!");
        }

        public void defeatQuote()
        {
            Console.WriteLine("Pfft. Jeg prøvde ikke engang...");
        }
    }
}
