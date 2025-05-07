using System;

public class Mage : IHero
{
    public string GetDescription() => "Маг";
    public int GetAttack() => 8;
    public int GetDefense() => 3;
    public int GetHealth() => 70;
    public int GetMana() => 50;
    public void Attack(IHero enemy)
    {
        int damage = GetAttack() - enemy.GetDefense();
        Console.WriteLine($"{GetDescription()} атакує {enemy.GetDescription()} магією на {Math.Max(damage, 0)} шкоди.");
    }
}
