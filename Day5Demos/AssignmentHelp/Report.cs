using System;
using System.Collections.Generic;

namespace Day5Demos.AssignmentHelp
{
    internal class Report
    {
        internal void ShowCustomerAccountList(List<Customer> customers)
        {
            Console.WriteLine("You selected menu 4");

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Code={customer.code}, Name={customer.name}");
            }

            Console.ReadKey();
        }

        internal void ShowAccountStatement(List<Customer> customers)
        {
            Console.WriteLine("You selected menu 5");
            Console.ReadKey();
        }
    }
}