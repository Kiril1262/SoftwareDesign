public interface IHero
{
    string GetDescription();
    int GetAttack();
    int GetDefense();
    int GetHealth();
    int GetMana();
    void Attack(IHero enemy);
}
