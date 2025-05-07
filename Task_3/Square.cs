using Task_3;

namespace Task_3
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.Render("Квадрат");
        }
    }
}

