namespace ViewImageProgram
{
    public class Circle
    {
        /*フィールド*/
        protected int _radius; 

        /*プロパティ*/
        public int Radius
        {
            set { _radius = value; }
            get { return _radius; }
        }
        /*コンストラクタ*/
        public Circle(int size)
        {
            _radius = size;
        }
    }
}