using System;
using WeekendAssignment1.Entities;

namespace WeekendAssignment1.ConsoleForm
{
    /// <summary>
    /// NOTE: IGNORE the save/cancel buttons on the pdf form design 
    /// They are not needed as when you press enter on last field 
    /// the input is anyway completed
    /// </summary>
    public class Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <returns></returns>
        public int DisplayMainMenu(int left, int top)
        {
            int menuId;
            ConsoleHelper.SetColor();

            // infinite loop
            do
            {
                menuId = 0;

                int row = top;

                Console.SetCursorPosition(left, row++);
                Console.Write("= Main Menu =================");
                Console.SetCursorPosition(left, row++);
                Console.Write("|                           |");
                Console.SetCursorPosition(left, row++);
                Console.Write("|  1.New Customer           |");
                Console.SetCursorPosition(left, row++);
                Console.Write("|  2.New Savings Account    |");
                Console.SetCursorPosition(left, row++);
                Console.Write("|  3.Transactions           |");
                Console.SetCursorPosition(left, row++);
                Console.Write("|  4.List Customer/Accounts |");
                Console.SetCursorPosition(left, row++);
                Console.Write("|  5.Account Statement      |");
                Console.SetCursorPosition(left, row++);
                Console.Write("|  6.Exit                   |");
                Console.SetCursorPosition(left, row++);
                Console.Write("|                           |");
                Console.SetCursorPosition(left, row);
                Console.Write("=============================");

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        menuId = 1;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        menuId = 2;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        menuId = 3;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        menuId = 4;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        menuId = 5;
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.Escape:
                        menuId = 6;
                        break;
                }
            } while (menuId == 0);

            ConsoleHelper.ResetColor();

            return menuId;
        }

        /// <summary>
        /// 
        /// </summary>
        internal void DisplayNewTransaction(int left, int top)
        {
            ConsoleHelper.SetColor();

            Console.WriteLine("You selected menu 3");
            Console.ReadKey();

            ConsoleHelper.ResetColor();
        }

        /// <summary>
        /// 
        /// </summary>
        internal void DisplayNewSavingAccount(int left, int top)
        {
            ConsoleHelper.SetColor();

            Console.WriteLine("You selected menu 2");
            Console.ReadKey();

            ConsoleHelper.ResetColor();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal Customer DisplayNewCustomer(int left, int top)
        {
            ConsoleHelper.SetColor();

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

            ConsoleHelper.ResetColor();

            return customer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <returns></returns>
        public LoginInfo DisplayLogin(int left, int top)
        {
            ConsoleHelper.SetColor();

            int row = top;
            Console.SetCursorPosition(left, row++);
            Console.Write("= Login =====================");
            Console.SetCursorPosition(left, row++);
            Console.Write("|                           |");
            Console.SetCursorPosition(left, row++);
            Console.Write("|  UserName: ____________   |");
            Console.SetCursorPosition(left, row++);
            Console.Write("|  Password: ____________   |");
            Console.SetCursorPosition(left, row++);
            Console.Write("|                           |");
            Console.SetCursorPosition(left, row);
            Console.Write("=============================");

            LoginInfo info = new LoginInfo();

            Console.SetCursorPosition(left + 13, top + 2);
            info.UserName = Console.ReadLine();

            Console.SetCursorPosition(left + 13, top + 3);
            info.Password = Console.ReadLine();

            ConsoleHelper.ResetColor();

            return info;
        }
    }
}
