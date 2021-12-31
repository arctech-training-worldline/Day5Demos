using System;

namespace WeekendAssignment1.ConsoleService.Form
{
    internal class FormBorder
    {
        private const char CharacterTopLeft = '\u250C';
        private const char CharacterTopRight = '\u2510';
        private const char CharacterBottomLeft = '\u2514';
        private const char CharacterBottomRight = '\u2518';
        private const char CharacterTop = '\u2500';
        private const char CharacterRight = '\u2502';
        private const char CharacterBottom = '\u2500';
        private const char CharacterLeft = '\u2502';

        public int Left { get; }
        public int Top { get; }
        public int Width { get; }
        public int Height { get; }

        private readonly FormTheme _formTheme;

        public FormBorder(int left, int top, int width, int height, FormTheme formTheme)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
            _formTheme = formTheme;
            //_formDesign = new FormDesign(left, top);
        }

        public bool DisplayRuler { get; set; }
        public int Right => Left + Width;
        public int Bottom => Top + Height;

        public void Display(string title)
        {
            if (DisplayRuler)
            {
                var consoleRuler = new ConsoleRuler(Left, Top, Width, Height);
                consoleRuler.DisplayRuler();
            }

            _formTheme.SetBorderColor();

            DisplayTitleBar(title);
            DisplaySideLines();
            DisplayBottomLine();

            _formTheme.ResetBorderColor();
        }

        private void DisplayTitleBar(string title)
        {
            title = title.Substring(0, Math.Min(title.Length, Width - 3));
            var topBorder = new string(CharacterTop, Width - 3 - title.Length);
            var line = $"{CharacterTopLeft}{CharacterTop}{title}{topBorder}{CharacterTopRight}";

            Console.SetCursorPosition(Left, Top);
            Console.Write(line);
        }

        private void DisplaySideLines()
        {
            var rowIndex = Top + 1;
            var right = Left + Width - 1;

            for (var i = 1; i < Height - 1; i++)
            {
                Console.SetCursorPosition(Left, rowIndex);
                Console.Write(CharacterLeft);

                Console.SetCursorPosition(right, rowIndex);
                Console.Write(CharacterRight);

                rowIndex++;
            }
        }

        private void DisplayBottomLine()
        {
            var bottomBorder = new string(CharacterBottom, Width - 3);
            var line = $"{CharacterBottomLeft}{CharacterBottom}{bottomBorder}{CharacterBottomRight}";

            Console.SetCursorPosition(Left, Top + Height - 1);
            Console.Write(line);
        }
    }
}
