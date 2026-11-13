/*Player player = new Player("Maciuś", 100, 9, 0, 35,50, 0);
Player player2 = new Player("Bob", 100, 20, 1, 45, 80, 1);
Enemy goblin = new Enemy("Goblin", 10, 8);
Enemy ork = new Enemy("Ork", 20, 5);

List<Enemy> enemies = new List<Enemy>
    {
         new Enemy("Goblin", 30, 8),
         new Enemy("Nietoperz", 20, 5),
         new Enemy("Ork", 70, 15)
     };

     foreach (Enemy enemy in enemies)
     {
         Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
     }

Console.WriteLine($"{player.Name} spotyka {goblin.Name}.");
Console.WriteLine($"{player2.Name} spotyka {ork.Name}.");
    
goblin.TakeDamage(5);
Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");
    
if (ork.IsAlive())
{
    player.TakeDamage(goblin.Damage);
    Console.WriteLine($"{player.Name} ma {player.Health} HP.");
    player.Heal(7);
}
else
{
    Console.WriteLine("Przeciwnik został pokonany.");
    player.DoswiadczenieTask1(19);
    Console.WriteLine(
        $"{player.Name} ma {player.Level} level, {player.Experience}/{player.MaxExperience} doswiadczenia i {player.Health}/{player.MaxHealth} HP.");
}

ork.TakeDamage(20);
Console.WriteLine($"{ork.Name} ma {ork.Health} HP.");
    
if (ork.IsAlive())
{
    player2.TakeDamage(ork.Damage);
    Console.WriteLine($"{player2.Name} ma {player2.Health} HP.");
    player2.Heal(7);
}
else
{
    Console.WriteLine("Przeciwnik został pokonany.");
    player2.DoswiadczenieTask1(19);
    Console.WriteLine(
        $"{player2.Name} ma {player2.Level} level, {player2.Experience}/{player2.MaxExperience} doswiadczenia i {player2.Health}/{player2.MaxHealth} HP.");
}*/