using WeekendAssignment1.Entities;
using System;
using System.Collections.Generic;
using WeekendAssignment1.ConsoleForm;
using WeekendAssignment1.ConsoleReport;

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
            Form form = new Form();
            LoginInfo loginInfo = form.DisplayLogin(45, 10);
            
            Console.WriteLine($"You entered Username={loginInfo.UserName}, Password={loginInfo.Password}");
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            Form form = new Form();
            Report report = new Report();
            
            int menuId;

            do
            {
                menuId = form.DisplayMainMenu(45, 10);

                switch (menuId)
                {
                    case 1:
                        Customer customer = form.DisplayNewCustomer(45, 10);
                        _customers.Add(customer);
                        break;
                    case 2:
                        form.DisplayNewSavingAccount(45, 10);
                        break;
                    case 3:
                        form.DisplayNewTransaction(45, 10);
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
