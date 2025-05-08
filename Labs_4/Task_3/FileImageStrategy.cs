using System;

public class FileImageStrategy : IImageLoadingStrategy
{
    public string LoadImage(string href)
    {
        return $"[Завантажено з файлу: {href}]";
    }
}
