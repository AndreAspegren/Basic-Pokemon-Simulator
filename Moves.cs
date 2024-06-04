using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Moves
    {
        internal string _name { get; private set; }
        internal int? _dmg { get; private set; }
        internal double _flinch { get; private set; }
        internal string _statType { get; private set; }
        internal int _statAmount { get; private set; }

        internal List<Moves> _allMoves = new()
        {
            new Moves("Tackle", 20, 0),
            new Moves("Bite", 30, 0.2),
            new Moves("Surf", 50, 0),
            new Moves("Giga Impact", 100, 0),
            new Moves("Dark Pulse", 70, 0.3),
            new Moves("Growl", "atk", 2/3),
            new Moves("Leer", "def", 2/3),
            new Moves("Ice Punch", 60, 0),
            new Moves("Rock Blast", 45, 0)
        };

        Moves(string name, int dmg, double flinch)
        {
            _name = name;
            _dmg = dmg;
            _flinch = flinch;
        }

        Moves(string name, string statType, int statAmount)
        {
            _name = name;
            _statType = statType;
            _statAmount = statAmount;
        }
        internal Moves(){}
    }
}
