public class Ring : HeroDecorator
{
    public Ring(IHero hero) : base(hero) { }
    public override string GetDescription() => hero.GetDescription() + ", перстень";
    public override int GetMana() => hero.GetMana() + 10;
}
