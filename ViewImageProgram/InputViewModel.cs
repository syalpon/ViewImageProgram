using System;

namespace ViewImageProgram
{
    public class InputViewModel 
    {
        private Circle _circle;
        private Square _square;
        public DelegateCommand CircleDelegateCommand { get; private set; }

        /* コンストラクタ*/
        public InputViewModel()
        {
            this.CircleDelegateCommand = new DelegateCommand(
                this.CircleExecute,
                this.CircleCanExecute
            );
        }
        

        /*円のボタン処理*/
        public bool CircleCanExecute(object parameter) {
            return true;
        }
        public void CircleExecute(object parameter) {
            CreateCircle(10);
        }

        /*四角のボタン処理*/
        public bool SquareCanExecute(object parameter)
        {
            return true;
        }
        public void SquareExecute(object parameter)
        {
            CreateSquare(10);
        }

        /*フィールドにインスタンスを登録*/
        public void CreateCircle(int size)
        {
            Console.WriteLine("push Circle Bottun");
            _circle = new Circle(size);
        }
        public void CreateSquare(int size)
        {
            Console.WriteLine("push Square Bottun");
            _square = new Square(size);
        }

        public Circle GetCricle()
        {
            return _circle;
        }
        public Square GetSquare()
        { 
            return _square;
        }
    }
}