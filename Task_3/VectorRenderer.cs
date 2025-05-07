using System;

namespace Task_3
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine("Малюємо " + shape + " як векторну графіку");
        }
    }
}

