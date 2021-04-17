namespace ViewImageProgram
{
    public class InputViewModel
    {
        private Circle _circle;
        private Square _square;

        public Circle Circle_Create(int size)
        {
            return new Circle(size);
        }
        public void Square_Create(int size)
        {
            _square = new Square(size);
        }

        public Circle get_Cricle()
        {
            return _circle;
        }
  
    }
}