using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTurtle
{
    class Screen
    {
        private char[] _screen;
        public int RowLength { get; }
        private int _maxRowIndex;
        private int _charsOnScreen;

        public Screen()
        {
            RowLength = Console.WindowWidth;
            _maxRowIndex = Console.WindowHeight - 3;
            _charsOnScreen = RowLength * _maxRowIndex;
            _screen = string.Empty.PadLeft(_charsOnScreen, ' ').ToCharArray();
        }

        public void DrawScreen()
        {
            for (var rowIndex = 0; rowIndex < _maxRowIndex; rowIndex++)
            {
                Console.WriteLine(_screen, rowIndex * RowLength, RowLength);
            }
        }

        public void DrawCharacter(Position position, char character)
        {
            var index = position.MyCol + RowLength * position.MyRow;
            _screen[index] = character;
        }
    }
}
