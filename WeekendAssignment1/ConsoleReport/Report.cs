using System;
using System.Collections.Generic;
using WeekendAssignment1.Entities;

namespace WeekendAssignment1.ConsoleReport
{
    /// <summary>
    /// 
    /// </summary>
    internal class Report
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customers"></param>
        internal void ShowCustomerAccountList(List<Customer> customers)
        {
            Console.WriteLine("You selected menu 4");

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Code={customer.code}, Name={customer.name}");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customers"></param>
        internal void ShowAccountStatement(List<Customer> customers)
        {
            Console.WriteLine("You selected menu 5");
            Console.ReadKey();
        }
    }
}