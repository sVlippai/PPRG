public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int MaxExperience { get; set; }
    public int Gold { get; set; }
    

    public Player(string name, int maxHealth, int health, int level, int experience, int maxexperience, int gold)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = health;
        Gold = gold;
        Level = level;
        Experience = experience;
        MaxExperience = maxexperience;
    }

    public void Doswiadczenie(int dodanie)
    {
        Experience += dodanie;
        
        if (Experience >= MaxExperience)
        {
            Experience = MaxExperience;
            MaxHealth += 20;
            Health = MaxHealth;
            Level++;
            MaxExperience += 30;

        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void Heal(int amount)
    {
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