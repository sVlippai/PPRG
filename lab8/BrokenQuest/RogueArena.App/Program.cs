Hero hero = new Hero("Ada", 100);
Companion companion = new Companion("Borys");
Monster monster = new Monster("Goblin", 45);

int reward = RewardCalculator.Calculate(monster.Health);
string report = BattleReport.Create(hero, monster, reward);
string report2 = PartyReport.Create(hero, monster, companion, reward);

Console.WriteLine($"Bohater: {hero.Name}");
Console.WriteLine($"Towarzysz: {companion.Name}");
Console.WriteLine($"Nagroda: {reward} szt. złota");
Console.WriteLine($"Report: {report}");
Console.WriteLine($"Party report: {report2}");
