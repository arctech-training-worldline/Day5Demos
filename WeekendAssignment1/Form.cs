using WeekendAssignment1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendAssignment1
{
    /// <summary>
    /// NOTE: IGNORE the save/cancel buttons on the pdf form design 
    /// They are not needed as when you press enter on last field 
    /// the input is anyway completed
    /// 
    /// 
    /// </summary>
    public class Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        internal void DisplayNewTransaction()
        {
            Console.WriteLine("You selected menu 3");
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        internal void DisplayNewSavingAccount()
        {
            Console.WriteLine("You selected menu 2");
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal Customer DisplayNewCustomer()
        {
            Console.WriteLine("You selected menu 1");

            Customer customer = new Customer();

            Console.WriteLine("Code: ");
            customer.code = Console.ReadLine();
            Console.WriteLine("Name: ");
            customer.name = Console.ReadLine();
            //Console.WriteLine("Address1: ");
            //customer.address1 = Console.ReadLine();
            //Console.WriteLine("Enter City: ");
            //customer.address2 = Console.ReadLine();
            //Console.WriteLine("Country: ");
            //customer.country = Console.ReadLine();
            //Console.WriteLine("Mobile: ");
            //customer.mobile = Console.ReadLine();
            //Console.WriteLine("PAN: ");
            //customer.pan = Console.ReadLine();
            //Console.WriteLine("Email: ");
            //customer.email = Console.ReadLine();
            //Console.WriteLine("Date Of Birth: ");
            //customer.dateOfBirth = Console.ReadLine();

            return customer;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
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
}
