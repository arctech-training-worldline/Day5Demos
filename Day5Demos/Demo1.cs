using Day5Demos.SchoolManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos
{
    internal class Demo1
    {
        public static void Test()
        {
            Student s1 = new Student { Name = "Suman" };

            Student s2 = s1;
            //s2.Name = "Shashi";

            //Console.WriteLine("s1 = " + s1.Name);   // Shashi
            //Console.WriteLine("s2 = " + s2.Name);   // Shashi

            string str1 = "Suman";

            string str2 = str1;
            // What is this magic? Why did it create a new copy of string
            // This is operator overloading to be studied later.
            //str2 = "Shashi";

            //Console.WriteLine("str1 = " + str1);    // Suman
            //Console.WriteLine("str2 = " + str2);    // Shashi
        }
    }
}
