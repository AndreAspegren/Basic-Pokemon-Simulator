using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon;

namespace Pokemon
{
    internal class Trainer : IHuman_Character
    {
        public string Name { get; set; }
        public int _maxPokemon { get; set; }

        internal Trainer(string name, int maxPokemon)
        {
            Name = name;
            _maxPokemon = maxPokemon;
        }
        public void greeting()
        {
            Console.WriteLine($"Det er meg! {Name}!");
        }

        public void defeatQuote()
        {
            Console.WriteLine("Jeg tapte... Hater å tape ;(");
        }
    }
}
