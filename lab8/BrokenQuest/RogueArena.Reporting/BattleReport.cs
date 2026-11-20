using RogueArena.Core.Characters;

namespace RogueArena.Reporting;

public static class BattleReport
{
    public static string Create(Hero hero, Monster monster, int reward)
    {
        return $"{hero.Name} pokonał: {monster.Name}; nagroda: {reward}.";
    }
}

public static class PartyReport
{
    public static string Create(Hero hero, Monster monster, Companion companion, int reward)
    {
        return $"Drużyna: {hero.Name} i {companion.Name}. Pokonali: {monster.Name}; nagroda: {reward}.";
    }
}