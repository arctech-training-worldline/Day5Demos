using WeekendAssignment1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendAssignment1.ConsoleService;
using WeekendAssignment1.ConsoleService.Form;

namespace WeekendAssignment1
{
    /// <summary>
    /// 
    /// </summary>
    internal class MonKeyBankingSolution
    {
        private readonly List<Customer> _customers;

        /// <summary>
        /// 
        /// </summary>
        public MonKeyBankingSolution()
        {
            _customers = new List<Customer>();
        }

        public void LoginTest()
        {
            var form = new Form();
            var loginInfo = form.DisplayLogin(45, 10);
            Console.WriteLine($"You entered Username={loginInfo.Username}, Password={loginInfo.Password}");
            Console.ReadKey();
        }

        public void ConsoleFormTest()
        {
            var formTheme = new FormTheme(ConsoleColor.DarkCyan, ConsoleColor.White, ConsoleColor.Yellow);
            //var form = new ConsoleForm("Hello World", 15, 5, 80, 20, formTheme);
            //form.Show();

            var formLogin = new FormLogin("Hello World", 15, 5, 30, 8, formTheme);
            formLogin.Show();
            var loginInfo = formLogin.GetInput<LoginInfo>();

            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            var form = new Form();
            var report = new Report();
            
            int menuId;

            do
            {
                menuId = form.DisplayMainMenu(45, 10);

                switch (menuId)
                {
                    case 1:
                        var customer = form.DisplayNewCustomer();
                        _customers.Add(customer);
                        break;
                    case 2:
                        form.DisplayNewSavingAccount();
                        break;
                    case 3:
                        form.DisplayNewTransaction();
                        break;
                    case 4:
                        report.ShowCustomerAccountList(_customers);
                        break;
                    case 5:
                        report.ShowAccountStatement(_customers);
                        break;
                    case 6:
                        Console.WriteLine("You selected menu 6. ** EXIT **");
                        Console.ReadKey();
                        break;
                }
            } while (menuId != 6);
        }
    }
}
