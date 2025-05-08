using System;

public class TextDocument
{
    private string _content = "";

    public void AppendLine(string text)
    {
        _content += text + Environment.NewLine;
    }

    public string GetContent()
    {
        return _content.TrimEnd();
    }

    public void SetContent(string content)
    {
        _content = content;
    }
}


