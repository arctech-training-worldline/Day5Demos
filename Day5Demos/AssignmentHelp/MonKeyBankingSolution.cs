using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos.AssignmentHelp
{
    internal class MonKeyBankingSolution
    {
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
                        form.DisplayNewCustomer();
                        break;
                    case 2:
                        form.DisplayNewSavingAccount();
                        break;
                    case 3:
                        form.DisplayNewTransaction();
                        break;
                    case 4:
                        report.ShowCustomerAccountList();
                        break;
                    case 5:
                        report.ShowAccountStatement();
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
