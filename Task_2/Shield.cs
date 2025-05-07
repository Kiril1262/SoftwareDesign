public class Shield : HeroDecorator
{
    public Shield(IHero hero) : base(hero) { }
    public override string GetDescription() => hero.GetDescription() + ", щит";
    public override int GetDefense() => hero.GetDefense() + 6;
}
