using System;

public class Paladin : IHero
{
    public string GetDescription() => "Паладин";
    public int GetAttack() => 9;
    public int GetDefense() => 7;
    public int GetHealth() => 90;
    public int GetMana() => 30;
    public void Attack(IHero enemy)
    {
        int damage = GetAttack() - enemy.GetDefense();
        Console.WriteLine($"{GetDescription()} атакує {enemy.GetDescription()} на {Math.Max(damage, 0)} шкоди.");
    }
}
