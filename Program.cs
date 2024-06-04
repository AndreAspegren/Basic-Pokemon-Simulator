namespace Pokemon
{
    class Program
    {
        private Instances_and_Variables i = new();

        internal async Task Run()
        {
            Console.WriteLine($@"Hvilken starter pokemon vil du velge?
1 for {i.p.pokemonList[0]._name},
2 for {i.p.pokemonList[1]._name},
3 for {i.p.pokemonList[2]._name}");
            int chosenPokemon = Convert.ToInt32(Console.ReadLine());
            i.p.trainerPokemon.Add(i.p.pokemonList[chosenPokemon - 1]);
            i.p.rivalPokemon.Add(i.p.pokemonList[i.random.Next(0, 3)]);

            while (i.isRunning)
            {
                Console.WriteLine("1 for sloss, 2 for fang pokemon");
                var actionInput = Console.ReadLine();

                if (actionInput == "1") await i.f.fight();
                else if (actionInput == "2") await i.ca.catchPokemon();
            }
        }
    }
}
