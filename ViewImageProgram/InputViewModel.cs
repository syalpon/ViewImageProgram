namespace ViewImageProgram
{
    public class InputViewModel
    {
        public Circle Circle_Create(int size)
        {
            return new Circle(size);
        }
        public Square Square_Create(int size)
        {
            return new Square(size);
        }
    }
}