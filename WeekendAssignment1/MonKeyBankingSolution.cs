using WeekendAssignment1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendAssignment1
{
    /// <summary>
    /// 
    /// </summary>
    internal class MonKeyBankingSolution
    {
        List<Customer> customers;

        /// <summary>
        /// 
        /// </summary>
        public MonKeyBankingSolution()
        {
            customers = new List<Customer>();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            Form form = new Form();
            Report report = new Report();
            //LoginInfo loginInfo = form.DisplayLogin(45, 10);
            //Console.WriteLine($"You entered Username={loginInfo.UserName}, Password={loginInfo.Password}");

            int menuId;

            do
            {
                menuId = form.DisplayMainMenu(45, 10);

                switch (menuId)
                {
                    case 1:
                        Customer customer = form.DisplayNewCustomer();
                        customers.Add(customer);
                        break;
                    case 2:
                        form.DisplayNewSavingAccount();
                        break;
                    case 3:
                        form.DisplayNewTransaction();
                        break;
                    case 4:
                        report.ShowCustomerAccountList(customers);
                        break;
                    case 5:
                        report.ShowAccountStatement(customers);
                        break;
                    case 6:
                        Console.WriteLine("You selected menu 6. ** EXIT **");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (menuId != 6);
        }
    }
}
