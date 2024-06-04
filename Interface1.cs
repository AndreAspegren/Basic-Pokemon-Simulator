using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal interface IHuman_Character
    {
        public string Name { get; set; }
        public int _maxPokemon { get; set; }
        public void greeting();
        public void defeatQuote();
    }
}
