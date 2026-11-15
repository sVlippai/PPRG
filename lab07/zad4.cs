/*bool graDziala = true;
int sumaHP = 0;
int pokonany = 0;

Random rnd = new Random();

List<Enemy> enemies = new List<Enemy>
        {
            new Enemy("Goblin", 50, 8),
            new Enemy("Nietoperz", 20, 5),
            new Enemy("Ork", 70, 15),
            new Enemy("Czarodzej", 60, 20),
            new Enemy("Szkielet", 25, 5)
        };
int rndIndex = rnd.Next(0, enemies.Count);
int rndIndex2 = rnd.Next(0, enemies.Count);
Enemy rndEnemy = enemies[rndIndex];
Enemy rndEnemy2 = enemies[rndIndex2];
Enemy compareHP = enemies[0];
int maxHpEnemy = compareHP.Health;
string compareName = null;
    for(int i = 0; i < enemies.Count; i++)
    {
        sumaHP += enemies[i].Health;
        
        if (enemies[i].Health > maxHpEnemy)
        {
             compareName = enemies[i].Name;
            maxHpEnemy = enemies[i].Health;
            
        }
        
    }
    

    void Enemies()
    {
        foreach (Enemy enemy in enemies)
        {
            Console.WriteLine($"{enemy.Name}: {enemy.Health} HP, {enemy.Damage} dmg.");
        }
        Console.WriteLine($"Liczba żywych: {enemies.Count}");
    }


while (graDziala)
{
    
    Player player = new Player("Maciuś", 100, 9, 0, 35, 50, 7);
    Player player2 = new Player("Bob", 100, 20, 1, 45, 80, 20);
    
    Enemies();

    Console.WriteLine($"{player.Name} spotyka {rndEnemy.Name}.");
    Console.WriteLine($"{player2.Name} spotyka {rndEnemy2.Name}.");

    rndEnemy.TakeDamage(player.Damage);
    Console.WriteLine($"{rndEnemy.Name} ma {rndEnemy.Health} HP.");

    if (rndEnemy.IsAlive())
    {
        player.TakeDamage(rndEnemy.Damage);
        Console.WriteLine($"{player.Name} ma {player.Health} HP.");
        player.Heal(7);
    }
    else
    {
        Console.WriteLine("Przeciwnik został pokonany.");
        enemies.RemoveAt(rndIndex);
        pokonany++;
        player.DoswiadczenieTask1(19);
        Console.WriteLine(
            $"{player.Name} ma {player.Level} level, {player.Experience}/{player.MaxExperience} doswiadczenia i {player.Health}/{player.MaxHealth} HP.");
    }

    rndEnemy2.TakeDamage(player2.Damage);
    Console.WriteLine($"{rndEnemy2.Name} ma {rndEnemy2.Health} HP.");

    if (rndEnemy2.IsAlive())
    {
        player2.TakeDamage(rndEnemy2.Damage);
        Console.WriteLine($"{player2.Name} ma {player2.Health} HP.");
        player2.Heal(7);
    }
    else
    {
        Console.WriteLine("Przeciwnik został pokonany.");
        enemies.RemoveAt(rndIndex2);
        pokonany++;
        player2.DoswiadczenieTask1(19);
        Console.WriteLine(
            $"{player2.Name} ma {player2.Level} level, {player2.Experience}/{player2.MaxExperience} doswiadczenia i {player2.Health}/{player2.MaxHealth} HP.");
    }
    Console.WriteLine("Contunujemy?(y/n)");
    string odpowiedz = Console.ReadLine();
    if (odpowiedz == "n")
    {
       break; 
    }
    
}
Enemies();
Console.WriteLine($"Suma ich punktów życia: {sumaHP}");
Console.WriteLine($"Liczba pokonanych przeciwników: {pokonany}");
Console.WriteLine($"Przeciwnik z największą liczbą HP: {compareName}, {maxHpEnemy} HP.");*/