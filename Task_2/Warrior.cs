using System;

public class Warrior : IHero
{
    public string GetDescription() => "Воїн";
    public int GetAttack() => 10;
    public int GetDefense() => 5;
    public int GetHealth() => 100;
    public int GetMana() => 20;
    public void Attack(IHero enemy)
    {
        int damage = GetAttack() - enemy.GetDefense();
        Console.WriteLine($"{GetDescription()} атакує {enemy.GetDescription()} на {Math.Max(damage, 0)} шкоди.");
    }
}
