using System.Collections.Generic;

public class History
{
    private readonly Stack<TextDocumentMemento> _mementos = new Stack<TextDocumentMemento>();

    public void Push(TextDocumentMemento memento)
    {
        _mementos.Push(memento);
    }

    public TextDocumentMemento Pop()
    {
        return _mementos.Count > 0 ? _mementos.Pop() : null;
    }
}

