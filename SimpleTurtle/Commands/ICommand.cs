using System;

namespace SimpleTurtle.Commands
{
    interface ICommand
    {
        bool IsCorrectKey(ConsoleKey key);
        void Run();
    }
}
