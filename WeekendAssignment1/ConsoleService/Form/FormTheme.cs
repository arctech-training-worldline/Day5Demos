using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendAssignment1.ConsoleService.Form
{
    internal class FormTheme
    {
        public ConsoleColor BackgroundColor { get; }
        public ConsoleColor ForegroundColor { get; }
        public ConsoleColor BorderColor { get; }

        private ConsoleColor _backupBackgroundColor;
        private ConsoleColor _backupForegroundColor;
        private ConsoleColor _backupBorderColor;

        public FormTheme(ConsoleColor backgroundColor, ConsoleColor foregroundColor, ConsoleColor borderColor)
        {
            BackgroundColor = backgroundColor;
            ForegroundColor = foregroundColor;
            BorderColor = borderColor;
        }

        public void SetFormColor()
        {
            _backupBackgroundColor = Console.BackgroundColor;
            Console.BackgroundColor = BackgroundColor;

            _backupForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ForegroundColor;
        }

        public void ResetFormColor()
        {
            Console.BackgroundColor = _backupBackgroundColor;
            Console.ForegroundColor = _backupForegroundColor;
        }

        public void SetBorderColor()
        {
            _backupBackgroundColor = Console.BackgroundColor;
            Console.BackgroundColor = BackgroundColor;

            _backupBorderColor = Console.ForegroundColor;
            Console.ForegroundColor = BorderColor;
        }

        public void ResetBorderColor()
        {
            Console.BackgroundColor = _backupBackgroundColor;
            Console.ForegroundColor = _backupBorderColor;
        }
    }
}
