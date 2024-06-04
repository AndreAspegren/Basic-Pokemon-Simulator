using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Fight
    {
        private Instances_and_Variables iv = new();
        private bool goodInput = true;
        internal async Task fight()
        {
            while (iv.p.trainerPokemon[0]._health > 0 && iv.p.rivalPokemon[0]._health > 0 || !iv.gameOn)
            {
                Console.Clear();
                Console.WriteLine($@"
Din pokemon:                                                      Rival Pokemon:
Navn: {iv.p.trainerPokemon[0]._name}                                 Navn: {iv.p.rivalPokemon[0]._name}
HP: {iv.p.trainerPokemon[0]._health}                                 HP: {iv.p.rivalPokemon[0]._health}                           
");

                while (goodInput)
                {
                    goodInput = false;
                    Console.WriteLine("1 for hit, 2 for flee");
                    var input = Console.ReadLine();

                    Console.WriteLine("Hvilket move velger du?");
                    for (var i = 0; i < iv.p.trainerPokemon[0]._moves.Length; i++) Console.WriteLine($"Trykk {i} for å velge {iv.p.trainerPokemon[0]._moves[i]}");

                    var trainerMove = Convert.ToInt32(Console.ReadLine());
                    var rivalMove = iv.p.rivalPokemon[0]._moves[iv.random.Next(0, iv.p.rivalPokemon[0]._moves.Length)];

                    if (input == "1") doTurn(trainerMove, rivalMove);
                    else if (input == "2") Flee();
                    else badInput();
                }
                Thread.Sleep(4000);
            }
        }

        private void badInput()
        {
            Console.WriteLine("Feil input!");
            goodInput = true;
        }

        private void Flee()
        {
            Console.WriteLine("Dette var for skummelt, nå stikker vi av!");
            iv.gameOn = false;
        }

        private void doTurn(int trainerMove, int rivalMove)
        {
            iv.p.trainerPokemon[0].changeHp(iv.p.rivalPokemon[0]._attack / iv.p.trainerPokemon[0]._defense);
            iv.p.rivalPokemon[0].changeHp(iv.p.trainerPokemon[0]._attack / iv.p.rivalPokemon[0]._defense);
        }
    }
}
