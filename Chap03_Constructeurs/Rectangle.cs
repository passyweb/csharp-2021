namespace Chap03_Constructeurs.Models
{
    public class Rectangle
    {
        public readonly float Width, Height;

        public Rectangle(float width, float height) =>
            (Width, Height) = (width, height);

        // public Rectangle(float width, float height)
        // {
        //     Width = width;
        //     Height= height;
        // }

        public void Deconstruct(out float width, out float height)
        {
            width = Width;
            height = Height;
        }
    }
}