using System;

namespace SimpleTurtle
{
    class Turtle
    {
        private Position _position;
        private Direction _direction;
        private Screen _screen;
        private const string Symbols = "A>V<";


        public Turtle()
        {
            Reset();
        }

        public void DrawScreen()
        {
            Console.Clear();
            _screen.DrawScreen();
        }

        public void Go()
        {
            _position.Move(_direction);
            var character = Symbols[(int)_direction];
            _screen.DrawCharacter(_position, character);
        }

        public void Turn(bool isTurnRight)
        {
            var delta = isTurnRight ? 1 : -1;
            _direction = (Direction)(((int)_direction + delta + 4) % 4);
        }

        public void Reset()
        {
            _direction = Direction.Right;
            _screen = new Screen();
            _position = new Position(_screen.RowLength / 2, Console.WindowHeight / 2);
        }
    }
}
