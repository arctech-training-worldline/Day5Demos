using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos
{
    public class LoginInfo
    {
        public string UserName;
        public string Password;
    }

    public class Form
    {
        public LoginInfo DisplayLogin(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            int row = y;
            Console.SetCursorPosition(x, row++);
            Console.WriteLine("= Login =====================");
            Console.SetCursorPosition(x, row++);
            Console.WriteLine("|                           |");
            Console.SetCursorPosition(x, row++);
            Console.WriteLine("|  UserName: ____________   |");
            Console.SetCursorPosition(x, row++);
            Console.WriteLine("|  Password: ____________   |");
            Console.SetCursorPosition(x, row++);
            Console.WriteLine("|                           |");
            Console.SetCursorPosition(x, row++);
            Console.WriteLine("=============================");

            LoginInfo info = new LoginInfo();

            Console.SetCursorPosition(x + 13, y + 2);
            info.UserName = Console.ReadLine();

            Console.SetCursorPosition(x + 13, y + 3);
            info.Password = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            return info;
        }
    }

    internal class ConsoleFormDemo
    {
        public static void Test()
        {
            Form form = new Form();
            LoginInfo loginInfo = form.DisplayLogin(45, 10);

            Console.Clear();

            Console.WriteLine($"You entered Username={loginInfo.UserName}, Password={loginInfo.Password}");
        }
    }
}
