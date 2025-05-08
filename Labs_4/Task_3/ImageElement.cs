public class ImageElement : LightElementNode
{
    private readonly string _href;
    private readonly IImageLoadingStrategy _strategy;

    public ImageElement(string href, IImageLoadingStrategy strategy)
        : base("img", DisplayType.Inline, ClosingType.SelfClosing)
    {
        _href = href;
        _strategy = strategy;
    }

    public string Load()
    {
        return _strategy.LoadImage(_href);
    }

    public override string OuterHTML
    {
        get
        {
            var indent = "  "; // базовий відступ
            var html = base.OuterHTML.TrimEnd('\n'); // базовий html з LightElementNode
            var comment = $"<!-- {Load()} -->";
            return $"{html}\n{indent}{comment}\n";
        }
    }
}


