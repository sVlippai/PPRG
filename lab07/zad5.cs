/*bool graDziala = true;
int sumaHP = 0;
int pokonany = 0;

List<Enemy> enemies = new List<Enemy>
        {
            new Enemy("Goblin", 50, 8),
            new Enemy("Nietoperz", 20, 5),
            new Enemy("Ork", 70, 15),
            new Enemy("Czarodzej", 60, 20),
            new Enemy("Szkielet", 25, 5)
        };
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
            Console.WriteLine($"{enemies.IndexOf(enemy) + 1}. {enemy.Name}: {enemy.Health} HP, {enemy.Damage} dmg.");
        }
        Console.WriteLine($"Liczba żywych: {enemies.Count}");
    }

    Enemies();
Console.WriteLine("Wybierz przeciwnika.");
int enemy;

while (true)
{
    bool format = int.TryParse(Console.ReadLine(), out enemy);
    
    if (!format)
    {
        Console.WriteLine("Wpisz liczbę.");
        continue;
    }
 
    if (enemy <= 0)
    {
        Console.WriteLine("Wybierz liczbę dodatna.");
        continue;
    }

    if (enemy - 1 >= enemies.Count)
    {
        Console.WriteLine("Wybierz liczbę od 1 do 5.");
        
    }
    
    else
    {
        break;
    }
}

while (graDziala)
{
    Player player = new Player("Maciuś", 100, 9, 0, 35, 50, 7);
    
    Console.WriteLine($"{player.Name} spotyka {enemies[enemy - 1].Name}.");

    enemies[enemy - 1].TakeDamage(player.Damage);
    Console.WriteLine($"{enemies[enemy - 1].Name} ma {enemies[enemy - 1].Health} HP.");

    if (enemies[enemy - 1].IsAlive())
    {
        player.TakeDamage(enemies[enemy - 1].Damage);
        Console.WriteLine($"{player.Name} ma {player.Health} HP.");
        player.Heal(7);
    }
    else
    {
        Console.WriteLine("Przeciwnik został pokonany.");
        enemies.RemoveAt(enemy - 1);
        pokonany++;
        player.DoswiadczenieTask1(19);
        Console.WriteLine(
            $"{player.Name} ma {player.Level} level, {player.Experience}/{player.MaxExperience} doswiadczenia i {player.Health}/{player.MaxHealth} HP.");
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