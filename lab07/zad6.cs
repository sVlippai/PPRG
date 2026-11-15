/*bool graDziala = true;
int sumaHP = 0;
int pokonany = 0;
string odpowiedz;
Player player = new Player("Maciuś", 100, 9, 1, 35, 50, 15);
List<Enemy> enemies = new List<Enemy>
        {
            new Enemy("Goblin", 50, 8),
            new Enemy("Nietoperz", 20, 5),
            new Enemy("Ork", 70, 15),
            new Enemy("Czarodzej", 60, 20),
            new Enemy("Szkielet", 25, 5)
        };

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
int tura = 1;

void Choice()
{
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
}

void Check()
{
    Console.WriteLine("Contunujemy?(y/n)");
    odpowiedz = Console.ReadLine();
   
}


Choice();

void StatisticsPlayer()
{
    Console.WriteLine($"Player: {player.Name} | HP: {player.Health} | Damage: {player.Damage}");
}
void StatisticsEnemy()
{
    Console.WriteLine($"Enemy: {enemies[enemy-1].Name} | HP: {enemies[enemy-1].Health} | Damage: {enemies[enemy-1].Damage}");
}

void Tura()
{
    Console.WriteLine($" ------ TURA {tura} ------ ");
    StatisticsPlayer();
}

while (graDziala && player.IsAlive())
    
{
    Tura();
    StatisticsEnemy();
    enemies[enemy - 1].TakeDamage(player.Damage);
    Console.WriteLine($"{enemies[enemy - 1].Name} ma {enemies[enemy - 1].Health} HP.");

    if (enemies[enemy - 1].IsAlive())
    {
        player.TakeDamage(enemies[enemy - 1].Damage);
        Console.WriteLine($"{player.Name} ma {player.Health} HP.");
        Check();
        if (odpowiedz == "n")
        { 
            break; 
        }
    }
    else
    {
        Console.WriteLine("Przeciwnik został pokonany.");
        enemies.RemoveAt(enemy - 1);
        pokonany++;
        player.DoswiadczenieTask1(19);
        Console.WriteLine($"Zwycięstwo! {player.Name} ma {player.Level} level, {player.Experience}/{player.MaxExperience} doswiadczenia i {player.Health}/{player.MaxHealth} HP.");
        Check();
        if (odpowiedz == "n")
        { 
            break; 
        }
        if (odpowiedz == "y")
        { 
            tura++;
            Enemies();
            Choice();
        }
    }
}
Tura();
if (!player.IsAlive())
{
    Console.WriteLine("Player is dead.");
}
Enemies();
Console.WriteLine($"Liczba pokonanych: {pokonany}");*/
