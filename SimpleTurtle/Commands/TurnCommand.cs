using System;
using SimpleTurtle.Commands;

namespace SimpleTurtle
{
    class TurnCommand : ICommand
    {
        private Turtle _turtle;
        private bool _isTurnRight;

        public TurnCommand(Turtle turtle, bool isTurnRight)
        {
            _isTurnRight = isTurnRight;
            _turtle = turtle;
        }
        public bool IsCorrectKey(ConsoleKey key)
        {
            //return (_isTurnRight&& key == ConsoleKey.RightArrow)||(!_isTurnRight&& key == ConsoleKey.LeftArrow);
            return _isTurnRight 
                ? key == ConsoleKey.RightArrow 
                : key == ConsoleKey.LeftArrow;
        }

        public void Run()
        {
            _turtle.Turn(_isTurnRight);
        }
    }
}
