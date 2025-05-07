public class Armor : HeroDecorator
{
    public Armor(IHero hero) : base(hero) { }
    public override string GetDescription() => hero.GetDescription() + ", броня";
    public override int GetDefense() => hero.GetDefense() + 4;
}
