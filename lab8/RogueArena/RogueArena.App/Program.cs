using RogueArena.App.UI;
using RogueArena.Core.Characters;
using RogueArena.Core.Combat;
using RogueArena.Core.Items;


Item miecz = new Item("Miecz", 40);
Item mikstura = new Item("Mikstura", 15);

Hero hero = new Hero("Ada", 100);
Monster monster = new Monster("Ork", 45);

Inventory.CalculateValue();
int damage = CombatRules.CalculateDamage(7, 5);
monster.TakeDamage(damage);

ArenaPrinter.ShowTitle("Rogue Arena");
Console.WriteLine($"{hero.Name} zadaje {damage} obrażeń.");
ArenaPrinter.ShowHealth(monster.Name, monster.Health);