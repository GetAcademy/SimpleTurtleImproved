using System;
using SimpleTurtle.Commands;

namespace SimpleTurtle
{
    class GoCommand : ICommand
    {
        private Turtle _turtle;

        public GoCommand(Turtle turtle)
        {
            _turtle = turtle;
        }
        public bool IsCorrectKey(ConsoleKey key)
        {
            return key == ConsoleKey.UpArrow;
        }

        public void Run()
        {
            _turtle.Go();
        }
    }
}
