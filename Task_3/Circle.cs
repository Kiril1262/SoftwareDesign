namespace Task_3
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.Render("Коло");
        }
    }
}
