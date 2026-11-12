
    Player player = new Player("Maciuś", 100, 25, 0, 35,50, 0);
    Enemy goblin = new Enemy("Goblin", 10, 8);
    
    Console.WriteLine($"{player.Name} spotyka {goblin.Name}.");
    
    goblin.TakeDamage(12);
    Console.WriteLine($"{goblin.Name} ma {goblin.Health} HP.");
    
    if (goblin.IsAlive())
    {
        player.TakeDamage(goblin.Damage);
        Console.WriteLine($"{player.Name} ma {player.Health} HP.");
    }
    else
    {
        Console.WriteLine("Przeciwnik został pokonany.");
        player.Doswiadczenie(15);
        Console.WriteLine($"{player.Name} ma {player.Level} level, {player.Experience}/{player.MaxExperience} doswiadczenia i {player.Health}/{player.MaxHealth} HP.");
    }

