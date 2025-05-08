using System;

public class ClickListener : IEventListener
{
    public void HandleEvent(LightElementNode element)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Подія 'click' відбулася на елементі <{element.TagName}> з класами: {string.Join(", ", element.CssClasses)}");
        Console.ResetColor();
    }
}

