namespace ViewImageProgram
{
    public class Circle
    {
        /*フィールド*/
        protected int _width ; // X size
        protected int _height; // Y size

        /*プロパティ*/
        public int Width
        {
            set { _width = value; }
            get { return _width; }
        }

        public int Height
        {
            set { _height = value; }
            get { return _height; }
        }
        /*コンストラクタ*/
        public Circle(int size)
        {
            _width  = size;
            _height = size;
        }
    }
}