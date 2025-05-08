using System;

public class MouseOverListener : IEventListener
{
    public void HandleEvent(LightElementNode element)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Подія 'mouseover' відбулася на елементі <{element.TagName}> з класами: {string.Join(", ", element.CssClasses)}");
        Console.ResetColor();
    }
}

