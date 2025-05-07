public class Boots : HeroDecorator
{
    public Boots(IHero hero) : base(hero) { }
    public override string GetDescription() => hero.GetDescription() + ", чоботи";
    public override int GetDefense() => hero.GetDefense() + 2;
}
