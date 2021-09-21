using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTurtle.Commands
{
    class ResetCommand : ICommand
    {
        private Turtle _turtle;

        public ResetCommand(Turtle turtle)
        {
            _turtle = turtle;
        }
        public bool IsCorrectKey(ConsoleKey key)
        {
            return key == ConsoleKey.Escape;
        }

        public void Run()
        {
            _turtle.Reset();
        }
    }
}
