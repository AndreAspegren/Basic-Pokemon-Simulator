namespace Pokemon
{
    class Program
    {
        private bool gameOn = true;
        private bool goodInput = true;
        private bool isRunning = true;
        private Pokemon p = new Pokemon();
        private Characters c = new Characters();
        private Moves m = new Moves();
        private Random random = new();

        

        internal async Task Run()
        {
            Console.WriteLine($@"Hvilken starter pokemon vil du velge?
1 for {p.pokemonList[0]._name},
2 for {p.pokemonList[1]._name},
3 for {p.pokemonList[2]._name}");
            int chosenPokemon = Convert.ToInt32(Console.ReadLine());
            p.trainerPokemon.Add(p.pokemonList[chosenPokemon - 1]);
            p.rivalPokemon.Add(p.pokemonList[random.Next(0, 3)]);

            while (isRunning)
            {
                Console.WriteLine("1 for sloss, 2 for fang pokemon");
                var actionInput = Console.ReadLine();

                if (actionInput == "1") await fight();
                else if (actionInput == "2") await catchPokemon();
            }
        }

        private async Task catchPokemon()
        {

            Console.WriteLine($@"Hvem vil du velge?");
            for (var i = 0; i < p.pokemonList.Count; i++)
            {
                Console.WriteLine(@$"Trykk {i} for å velge {p.pokemonList[i]._name}
Navn: {p.pokemonList[i]._name}
Health: {p.pokemonList[i]._health}
Attack: {p.pokemonList[i]._attack}
Defense: {p.pokemonList[i]._defense}
Speed: {p.pokemonList[i]._speed}
");
            }

            var input = Convert.ToInt32(Console.ReadLine());
            
            var rand = random.Next(0, 101);
            if (rand > 50)
            {
                p.trainerPokemon.Add(p.pokemonList[input]);
                Console.WriteLine($"Du fanget {p.pokemonList[input]._name}");
            }
            else if (rand < 50) Console.WriteLine($"{p.pokemonList[input]._name} stakk av. Unlucky");
            
            Thread.Sleep(4000);
        }

        private async Task fight()
        {
            while (p.trainerPokemon[0]._health > 0 && p.rivalPokemon[0]._health > 0 || !gameOn)
            {
                Console.Clear();
                Console.WriteLine($@"
Din pokemon:                                                      Rival Pokemon:
Navn: {p.trainerPokemon[0]._name}                                 Navn: {p.rivalPokemon[0]._name}
HP: {p.trainerPokemon[0]._health}                                 HP: {p.rivalPokemon[0]._health}                           
");
                
                while (goodInput)
                {
                    goodInput = false;
                    Console.WriteLine("1 for hit, 2 for flee");
                    var input = Console.ReadLine();

                    Console.WriteLine("Hvilket move velger du?");
                    for (var i = 0; i < p.trainerPokemon[0]._moves.Length; i++) Console.WriteLine($"Trykk {i} for å velge {p.trainerPokemon[0]._moves[i]}");
                    
                    var trainerMove = Convert.ToInt32(Console.ReadLine());
                    var rivalMove = p.rivalPokemon[0]._moves[random.Next(0, p.rivalPokemon[0]._moves.Length)];

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
            gameOn = false;
        }

        private void doTurn(int trainerMove, int rivalMove)
        {
            p.trainerPokemon[0].changeHp(p.rivalPokemon[0]._attack / p.trainerPokemon[0]._defense);
            p.rivalPokemon[0].changeHp(p.trainerPokemon[0]._attack / p.rivalPokemon[0]._defense);
        }
    }
}
