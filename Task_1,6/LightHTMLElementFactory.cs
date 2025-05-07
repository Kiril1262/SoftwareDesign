using System.Collections.Generic;

public class LightHTMLElementFactory
{
    private Dictionary<string, LightHTMLElement> _elements;

    public LightHTMLElementFactory()
    {
        _elements = new Dictionary<string, LightHTMLElement>();
    }

    public LightHTMLElement GetElement(string tagName, string content)
    {
        var key = tagName + ":" + content;
        if (!_elements.ContainsKey(key))
        {
            _elements[key] = new LightHTMLElement(tagName, content);
        }
        return _elements[key];
    }
}


