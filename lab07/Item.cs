
public class Item
{
    public string Name { get; }
    public int Power { get; }
    public int Amount { get; set; }

    public Item(string name, int power, int amount)
    {
        Name = name;
        Power = power;
        Amount = amount;
    }
    

    public void Use()
    { 
        Amount--;
    }
}