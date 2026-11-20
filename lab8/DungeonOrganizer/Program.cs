using DungeonOrganizer.Characters;
using DungeonOrganizer.Items;
using DungeonOrganizer.UI;
using MapItem = DungeonOrganizer.World.Item;
using InvertoryItem = DungeonOrganizer.Items.Item;


Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
InvertoryItem invertoryitem = new InvertoryItem("Mikstura", 15);
Weapon weapon = new Weapon("Miecz", 8);
MapItem mapitem = new MapItem("!");


GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(invertoryitem.Name, invertoryitem.Price);
GamePrinter.ShowWeapon(weapon.Name, weapon.Damage);
GamePrinter.ShowSymbol(mapitem.Symbol);

