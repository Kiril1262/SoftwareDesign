public abstract class HeroDecorator : IHero
{
    protected IHero hero;
    public HeroDecorator(IHero hero) => this.hero = hero;

    public virtual string GetDescription() => hero.GetDescription();
    public virtual int GetAttack() => hero.GetAttack();
    public virtual int GetDefense() => hero.GetDefense();
    public virtual int GetHealth() => hero.GetHealth();
    public virtual int GetMana() => hero.GetMana();
    public virtual void Attack(IHero enemy) => hero.Attack(enemy);
}
