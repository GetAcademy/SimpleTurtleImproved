using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleTurtle.Commands;

namespace SimpleTurtle
{
    class Program
    {
        static void Main(string[] args)
        {
            var turtle = new Turtle();
            var commands = new ICommand[]
            {
                new GoCommand(turtle), 
                new TurnCommand(turtle, true), 
                new TurnCommand(turtle, false), 
                new ResetCommand(turtle), 
            };
            while (true)
            {
                turtle.DrawScreen();
                Console.WriteLine("Kommandoer: pil opp = GO, pil venstre = TURN LEFT, pil høyre = TURN RIGHT");
                var key = Console.ReadKey().Key;
                var command = commands.FirstOrDefault(cmd => cmd.IsCorrectKey(key));
                command?.Run();
                //foreach (var command in commands)
                //{
                //    if (!command.IsCorrectKey(key)) continue;
                //    command.Run();
                //    break;
                //}
            }
        }
    }
}
