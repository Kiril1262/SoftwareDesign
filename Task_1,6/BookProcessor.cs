public class BookProcessor
{
    private LightHTMLElementFactory _factory;
    private HTMLRenderer _renderer;

    public BookProcessor()
    {
        _factory = new LightHTMLElementFactory();
        _renderer = new HTMLRenderer();
    }

    public void ProcessBook(string[] lines)
    {
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            string tag;
            if (_renderer.IsEmpty())
            {
                tag = "h1";
            }
            else if (line.Length < 20)
            {
                tag = "h2";
            }
            else if (char.IsWhiteSpace(line[0]))
            {
                tag = "blockquote";
            }
            else
            {
                tag = "p";
            }

            var element = _factory.GetElement(tag, line.Trim());
            _renderer.AddElement(element);
        }
    }

    public string Render()
    {
        return _renderer.Render();
    }

    public int GetMemorySize()
    {
        return _renderer.GetByteSize();
    }
}

