using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Catch
    {
        private Instances_and_Variables iv = new();
        internal async Task catchPokemon()
        {

            Console.WriteLine($@"Hvem vil du velge?");
            for (var i = 0; i < iv.p.pokemonList.Count; i++)
            {
                Console.WriteLine(@$"Trykk {i} for å velge {iv.p.pokemonList[i]._name}
Navn: {iv.p.pokemonList[i]._name}
Health: {iv.p.pokemonList[i]._health}
Attack: {iv.p.pokemonList[i]._attack}
Defense: {iv.p.pokemonList[i]._defense}
Speed: {iv.p.pokemonList[i]._speed}
");
            }

            var input = Convert.ToInt32(Console.ReadLine());

            var rand = iv.random.Next(0, 101);
            if (rand > 50)
            {
                iv.p.trainerPokemon.Add(iv.p.pokemonList[input]);
                Console.WriteLine($"Du fanget {iv.p.pokemonList[input]._name}");
            }
            else if (rand < 50) Console.WriteLine($"{iv.p.pokemonList[input]._name} stakk av. Unlucky");

            Thread.Sleep(4000);
        }
    }
}
