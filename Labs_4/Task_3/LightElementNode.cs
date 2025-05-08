using System;
using System.Collections.Generic;
using System.Text;

public enum DisplayType
{
    Block,
    Inline
}

public enum ClosingType
{
    SelfClosing,
    WithClosingTag
}

public class LightElementNode : LightNode
{
    public string TagName { get; }
    public DisplayType Display { get; }
    public ClosingType Closing { get; }
    public List<string> CssClasses { get; }
    public List<LightNode> Children { get; }
    private Dictionary<string, List<IEventListener>> eventListeners;

    public LightElementNode(string tagName, DisplayType display, ClosingType closing)
    {
        TagName = tagName;
        Display = display;
        Closing = closing;
        CssClasses = new List<string>();
        Children = new List<LightNode>();
        eventListeners = new Dictionary<string, List<IEventListener>>();
    }

    public void AddClass(string className)
    {
        CssClasses.Add(className);
    }

    public void AddChild(LightNode child)
    {
        Children.Add(child);
    }

    public void AddEventListener(string eventType, IEventListener listener)
    {
        if (!eventListeners.ContainsKey(eventType))
        {
            eventListeners[eventType] = new List<IEventListener>();
        }
        eventListeners[eventType].Add(listener);
    }

    public void TriggerEvent(string eventType)
    {
        if (eventListeners.ContainsKey(eventType))
        {
            foreach (var listener in eventListeners[eventType])
            {
                listener.HandleEvent(this);
            }
        }
    }

    public override string InnerHTML => RenderInner(1);

    public override string OuterHTML => Render(0);

    private string Render(int indentLevel)
    {
        var indent = new string(' ', indentLevel * 2);
        var sb = new StringBuilder();

        sb.Append(indent).Append("<").Append(TagName);
        if (CssClasses.Count > 0)
        {
            sb.Append(" class=\"").Append(string.Join(" ", CssClasses)).Append("\"");
        }

        if (Closing == ClosingType.SelfClosing)
        {
            sb.Append(" />\n");
        }
        else
        {
            sb.Append(">\n");
            sb.Append(RenderInner(indentLevel + 1));
            sb.Append(indent).Append("</").Append(TagName).Append(">\n");
        }

        return sb.ToString();
    }

    private string RenderInner(int indentLevel)
    {
        var sb = new StringBuilder();
        var indent = new string(' ', indentLevel * 2);

        foreach (var child in Children)
        {
            if (child is LightElementNode element)
            {
                sb.Append(element.Render(indentLevel));
            }
            else
            {
                sb.Append(indent).Append(child.OuterHTML).Append("\n");
            }
        }

        return sb.ToString();
    }
}
