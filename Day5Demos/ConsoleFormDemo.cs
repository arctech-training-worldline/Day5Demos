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
        public int DisplayMainMenu(int x, int y)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            int menuId = 0;

            // infinte loop
            do
            {
                int col = x;
                int row = y;
                Console.SetCursorPosition(col, row++);
                Console.Write("= Main Menu =================");
                Console.SetCursorPosition(col, row++);
                Console.Write("|                           |");
                Console.SetCursorPosition(col, row++);
                Console.Write("|  1.New Customer           |");
                Console.SetCursorPosition(col, row++);
                Console.Write("|  2.New Savings Account    |");
                Console.SetCursorPosition(col, row++);
                Console.Write("|  3.Transactions           |");
                Console.SetCursorPosition(col, row++);
                Console.Write("|  4.List Customer/Accounts |");
                Console.SetCursorPosition(col, row++);
                Console.Write("|  5.Account Statement      |");
                Console.SetCursorPosition(col, row++);
                Console.Write("|  6.Exit                   |");
                Console.SetCursorPosition(col, row++);
                Console.Write("|                           |");
                Console.SetCursorPosition(col, row++);
                Console.Write("=============================");

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

                if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
                {
                    menuId = 1;
                    break;
                }
                else if (consoleKeyInfo.Key == ConsoleKey.D2 || consoleKeyInfo.Key == ConsoleKey.NumPad2)
                {
                    menuId = 2;
                    break;
                }
                else if (consoleKeyInfo.Key == ConsoleKey.D3 || consoleKeyInfo.Key == ConsoleKey.NumPad3)
                {
                    menuId = 3;
                    break;
                }
                else if (consoleKeyInfo.Key == ConsoleKey.D4 || consoleKeyInfo.Key == ConsoleKey.NumPad4)
                {
                    menuId = 4;
                    break;
                }
                else if (consoleKeyInfo.Key == ConsoleKey.D5 || consoleKeyInfo.Key == ConsoleKey.NumPad5)
                {
                    menuId = 5;
                    break;
                }
                else if (consoleKeyInfo.Key == ConsoleKey.D6 || consoleKeyInfo.Key == ConsoleKey.NumPad6
                            || consoleKeyInfo.Key == ConsoleKey.Escape)
                {
                    menuId = 6;
                    break;
                }
            } while (true);


            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();

            return menuId;
        }
        public LoginInfo DisplayLogin(int x, int y)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            int col = x;
            int row = y;
            Console.SetCursorPosition(col, row++);
            Console.Write("= Login =====================");
            Console.SetCursorPosition(col, row++);
            Console.Write("|                           |");
            Console.SetCursorPosition(col, row++);
            Console.Write("|  UserName: ____________   |");
            Console.SetCursorPosition(col, row++);
            Console.Write("|  Password: ____________   |");
            Console.SetCursorPosition(col, row++);
            Console.Write("|                           |");
            Console.SetCursorPosition(col, row++);
            Console.Write("=============================");

            LoginInfo info = new LoginInfo();

            Console.SetCursorPosition(x + 13, y + 2);
            info.UserName = Console.ReadLine();

            Console.SetCursorPosition(x + 13, y + 3);
            info.Password = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();

            return info;
        }
    }

    internal class ConsoleFormDemo
    {
        public static void Test()
        {
            Form form = new Form();
            //LoginInfo loginInfo = form.DisplayLogin(45, 10);

            //Console.WriteLine($"You entered Username={loginInfo.UserName}, Password={loginInfo.Password}");

            int menuId;

            do
            {
                menuId = form.DisplayMainMenu(45, 10);

                switch (menuId)
                {
                    case 1:
                        Console.WriteLine("You selected menu 1");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("You selected menu 2");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("You selected menu 3");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("You selected menu 4");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("You selected menu 5");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("You selected menu 6");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (menuId != 6);
        }
    }
}
