

public class Enemy
{
    

    
    public string Name { get; }
    public int Health { get; set; }
    public int Damage { get; }

    public Enemy(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
        
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
 /*List<Enemy> enemies = new List<Enemy>
        {
             new Enemy("Goblin", 30, 8),
             new Enemy("Nietoperz", 20, 5),
             new Enemy("Ork", 70, 15)
         };
 
         foreach (Enemy enemy in enemies) 
         { 
             Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
         }*/