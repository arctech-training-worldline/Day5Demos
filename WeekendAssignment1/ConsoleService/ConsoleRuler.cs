using System;
using System.Text;

namespace WeekendAssignment1.ConsoleService
{
    internal class ConsoleRuler
    {
        private readonly int _left;
        private readonly int _top;
        private readonly int _width;
        private readonly int _height;

        public ConsoleRuler(int left, int top, int width, int height)
        {
            _left = left;
            _top = top;
            _width = width;
            _height = height;
        }

        public void DisplayRuler()
        {
            DisplayHorizontalRuler();
            DisplayVerticalRuler();
        }

        private void DisplayHorizontalRuler()
        {
            var sb = new StringBuilder();
            var rulerNumber = '1';

            for (var i = 0; i < _width; i++)
            {
                sb.Append(rulerNumber);

                if (++rulerNumber > '9')
                    rulerNumber = '0';
            }

            Console.SetCursorPosition(_left, _top - 1);
            Console.Write(sb.ToString());
        }

        private void DisplayVerticalRuler()
        {
            var left = _left - 1;
            var top = _top;
            var rulerNumber = '1';

            for (var i = 0; i < _height; i++)
            {
                Console.SetCursorPosition(left, top++);
                Console.Write(rulerNumber);

                if (++rulerNumber > '9')
                    rulerNumber = '0';
            }
        }
    }
}
