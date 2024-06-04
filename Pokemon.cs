using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemon
    {
        public string _name { get; private set; }
        public int  _health { get; private set; }
        public int _attack { get; private set; }

        public int _defense { get; private set; }
        public int _speed { get; private set; }

        public int[] _moves = new int[4];

        public Pokemon(string name, int health, int attack, int defense, int speed, int[] moves)
        {
            _name = name;
            _health = health;
            _attack = attack;
            _defense = defense;
            _speed = speed;
            _moves = moves;
        }

        public void changeHp(int dmg)
        {
            _health -= dmg;
        }
        internal Pokemon(){}

        public List<Pokemon> pokemonList = new()
        {
            new Pokemon("Bulbasaur", 20, 7, 8, 3, [0, 5, 6]),
            new Pokemon("Squirtle", 15, 5, 7, 5, [0, 1, 2]),
            new Pokemon("Charmander", 30, 3, 7, 6, [0, 1]),
            new Pokemon("Pikachu", 10, 15, 5, 7, [0, 6]),
            new Pokemon("Sneasel", 15, 35, 6, 10, [4, 7]),
            new Pokemon("Nosepass", 50, 8, 15, 2, [0, 8]),
            new Pokemon("Slowpoke", 28, 20, 9, 4, [6, 2]),
            new Pokemon("Geodude", 40, 5, 10, 3, [8, 0, 5])
        };

        internal List<Pokemon> trainerPokemon = new();
        internal List<Pokemon> rivalPokemon = new();
    }
}
