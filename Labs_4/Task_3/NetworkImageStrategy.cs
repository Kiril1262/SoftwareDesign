using System;

public class NetworkImageStrategy : IImageLoadingStrategy
{
    public string LoadImage(string href)
    {
        return $"[Завантажено з мережі: {href}]";
    }
}

