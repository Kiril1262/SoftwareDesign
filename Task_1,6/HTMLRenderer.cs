using System.Collections.Generic;
using System.Text;

public class HTMLRenderer
{
    private List<LightHTMLElement> _elements;

    public HTMLRenderer()
    {
        _elements = new List<LightHTMLElement>();
    }

    public void AddElement(LightHTMLElement element)
    {
        _elements.Add(element);
    }

    public string Render()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < _elements.Count; i++)
        {
            sb.AppendLine(_elements[i].Render());
        }
        return sb.ToString();
    }

    public int GetByteSize()
    {
        return Encoding.UTF8.GetByteCount(Render());
    }

    public bool IsEmpty()
    {
        return _elements.Count == 0;
    }
}

