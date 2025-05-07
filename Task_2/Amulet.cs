public class Amulet : HeroDecorator
{
    public Amulet(IHero hero) : base(hero) { }
    public override string GetDescription() => hero.GetDescription() + ", амулет";
    public override int GetAttack() => hero.GetAttack() + 2;
    public override int GetDefense() => hero.GetDefense() + 1;
}
