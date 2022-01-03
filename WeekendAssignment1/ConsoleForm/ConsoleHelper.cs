using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendAssignment1.ConsoleForm
{
    internal static class ConsoleHelper
    {
        public static void SetColor()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
        }

        public static void ResetColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
