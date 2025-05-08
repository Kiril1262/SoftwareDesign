public class TextEditor
{
    private readonly TextDocument _document = new TextDocument();
    private readonly History _history = new History();

    public void WriteLine(string text)
    {
        _document.AppendLine(text);
    }

    public void Save()
    {
        _history.Push(new TextDocumentMemento(_document.GetContent()));
    }

    public void Undo()
    {
        var memento = _history.Pop();
        if (memento != null)
        {
            _document.SetContent(memento.Content);
        }
    }

    public string GetText()
    {
        return _document.GetContent();
    }
}


