public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int MaxExperience { get; set; }
    public int Gold { get; set; }
    public int Damage { get; set; }
    
    
    public Player(string name, int maxHealth, int health, int level, int experience, int maxexperience, int damage)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = health;
        Level = level;
        Experience = experience;
        MaxExperience = maxexperience;
        Damage = damage;
    }

    public void DoswiadczenieTask1(int dodanie)
    {
        Experience += dodanie;
        
        if (Experience >= MaxExperience)
        {
            Experience -= MaxExperience;
            MaxHealth += 20;
            Health = MaxHealth;
            Level++;
            MaxExperience += 30;

        }
    }

    public void TakeDamage(int damage)
    {
        if (damage == 0 || damage < 0)
        {
            Console.WriteLine("Atak sie nie udal.");
            return;
        }


        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
        
    }

    public void Heal(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Healing was declined.");
            return;
        }
        if (!IsAlive())
        {
            Console.WriteLine("Player is dead. Healing was declined.");
            return;
        }
        Health += amount;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
