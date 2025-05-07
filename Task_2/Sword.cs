public class Sword : HeroDecorator
{
    public Sword(IHero hero) : base(hero) { }
    public override string GetDescription() => hero.GetDescription() + ", меч";
    public override int GetAttack() => hero.GetAttack() + 5;
}
