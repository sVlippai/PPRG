using RogueArena.Core.Characters;
using RogueArena.Core.Rewards;

Hero hero = new Hero("Ada", 100);
Companion companion = new Companion("Borys");

int reward = RewardCalculator.Calculate(45);

Console.WriteLine($"Bohater: {hero.Name}");
Console.WriteLine($"Towarzysz: {companion.Name}");
Console.WriteLine($"Nagroda: {reward} szt. złota");