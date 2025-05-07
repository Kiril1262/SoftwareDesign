using System.Collections.Generic;
using System.Text;

public class LightHTMLElement
{
    public string TagName { get; private set; }
    public string Content { get; private set; }
    public List<LightHTMLElement> Children { get; private set; }

    public LightHTMLElement(string tagName, string content)
    {
        TagName = tagName;
        Content = content;
        Children = new List<LightHTMLElement>();
    }

    public void AddChild(LightHTMLElement child)
    {
        Children.Add(child);
    }

    public string Render()
    {
        var sb = new StringBuilder();
        sb.Append("<" + TagName + ">");
        sb.Append(Content);
        foreach (var child in Children)
        {
            sb.Append(child.Render());
        }
        sb.Append("</" + TagName + ">");
        return sb.ToString();
    }
}


