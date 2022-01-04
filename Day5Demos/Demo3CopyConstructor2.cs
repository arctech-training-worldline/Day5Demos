using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos
{
    class Department
    {
        public int id;
        public string name;
    }

    class Employee
    {
        public string code;
        public string name;
        public Department department;

        public Employee()
        { }

        /// <summary>
        /// Instead of creating new new functions like CreateDeepCopy etc.
        /// Create a single Copy Constructor
        /// </summary>
        /// <param name="employee"></param>
        public Employee(Employee employee)
        {
            code = employee.code;
            name = employee.name;
            department = new Department { id = employee.department.id, name = employee.department.name };
        }

        public Employee CreateShallowCopy()
        {
            Employee newEmployee = new Employee
            {
                code = code,
                name = name,
                department = department
            };

            return newEmployee;
        }

        public Employee CreateDeepCopy()
        {
            Employee newEmployee = new Employee
            {
                code = code,
                name = name,
                department = new Department { id = department.id, name = department.name }
            };
            return newEmployee;
        }
    }

    internal static class Demo3CopyConstructor2
    {

        /// <summary>
        /// Without any class method or copy constructor, it is very tedious to create copies of existing objects.
        /// So do not do this.
        /// </summary>
        public static void CopyConstructorTest1()
        {
            Department newDepartment = new Department { id = 1, name = "Sales" };
            Employee employee = new Employee { code = "101", name = "Raman Gujral", department = newDepartment };

            Employee employee2 = employee;
            employee2.code = "102";
            employee2.department.name = "HR";

            Employee employee3 = new Employee { code = employee.code, name = employee.name, department = employee.department };

            employee3.code = "103";
            employee2.department.name = "IT";

            Employee employee4 = new Employee
            {
                code = employee.code,
                name = employee.name,
                department = new Department { id = employee.department.id, name = employee.department.name }
            };
            employee4.code = "104";
            employee4.department.name = "Marketing";

            Console.WriteLine($"{"EmpCode",-10}|{"Name",-20}|{"Department",-15}");
            Console.WriteLine($"{employee.code,-10}|{employee.name,-20}|{employee.department.name,-15}");
            // 102, Raman Gujral, IT
            Console.WriteLine($"{employee2.code,-10}|{employee2.name,-20}|{employee2.department.name,-15}");
            // 102, Raman Gujral, IT
            Console.WriteLine($"{employee3.code,-10}|{employee3.name,-20}|{employee3.department.name,-15}");
            // 103, Raman Gujral, IT
            Console.WriteLine($"{employee4.code,-10}|{employee4.name,-20}|{employee4.department.name,-15}");
            // 104, Raman Gujral, Marketing
            Console.WriteLine($"{employee4.code,-10}|{employee4.name,-20}|{employee4.department.name,-15}");
        }

        /// <summary>
        /// Using a class method like CreateDeepCopy(), it is easier to create copies of existing objects.
        /// However, programmers still have to learn a new method and remember to use it.
        /// So do not do this.
        /// </summary>
        public static void CopyConstructorTest2()
        {
            Department newDepartment = new Department { id = 1, name = "Sales" };
            Employee employee = new Employee { code = "101", name = "Raman Gujral", department = newDepartment };

            Employee employee2 = employee;
            employee2.code = "102";
            employee2.department.name = "HR";

            Employee employee3 = employee.CreateShallowCopy();
            employee3.code = "103";
            employee2.department.name = "IT";

            Employee employee4 = employee.CreateDeepCopy();
            employee4.code = "104";
            employee4.department.name = "Marketing";

            Console.WriteLine($"{"EmpCode",-10}|{"Name",-20}|{"Department",-15}");
            Console.WriteLine($"{employee.code,-10}|{employee.name,-20}|{employee.department.name,-15}");
            // 102, Raman Gujral, IT
            Console.WriteLine($"{employee2.code,-10}|{employee2.name,-20}|{employee2.department.name,-15}");
            // 102, Raman Gujral, IT
            Console.WriteLine($"{employee3.code,-10}|{employee3.name,-20}|{employee3.department.name,-15}");
            // 103, Raman Gujral, IT
            Console.WriteLine($"{employee4.code,-10}|{employee4.name,-20}|{employee4.department.name,-15}");
            // 104, Raman Gujral, Marketing
            Console.WriteLine($"{employee4.code,-10}|{employee4.name,-20}|{employee4.department.name,-15}");
        }

        /// <summary>
        /// Using a Copy Constructor, it is easiest to create copies of existing objects.
        /// All C#, C++, Java programmers know what it is and how to use it.
        /// Always use copy constructor in classes whenever you need to create copies of any class object.
        /// </summary>
        public static void CopyConstructorTest3()
        {
            Department newDepartment = new Department { id = 1, name = "Sales" };
            Employee employee = new Employee { code = "101", name = "Raman Gujral", department = newDepartment };

            Employee employee2 = employee;

            employee2.code = "102";
            employee2.department.name = "HR";

            Employee employee3 = new Employee(employee);

            employee3.code = "103";
            employee2.department.name = "IT";

            Employee employee4 = new Employee(employee);

            employee4.code = "104";
            employee4.department.name = "Marketing";

            Console.WriteLine($"{"EmpCode",-10}|{"Name",-20}|{"Department",-15}");
            Console.WriteLine($"{employee.code,-10}|{employee.name,-20}|{employee.department.name,-15}");
            // 102, Raman Gujral, IT
            Console.WriteLine($"{employee2.code,-10}|{employee2.name,-20}|{employee2.department.name,-15}");
            // 102, Raman Gujral, IT
            Console.WriteLine($"{employee3.code,-10}|{employee3.name,-20}|{employee3.department.name,-15}");
            // 103, Raman Gujral, IT
            Console.WriteLine($"{employee4.code,-10}|{employee4.name,-20}|{employee4.department.name,-15}");
            // 104, Raman Gujral, Marketing
            Console.WriteLine($"{employee4.code,-10}|{employee4.name,-20}|{employee4.department.name,-15}");
        }
    }
}
