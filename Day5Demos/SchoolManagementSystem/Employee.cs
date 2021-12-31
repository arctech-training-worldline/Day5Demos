using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos.SchoolManagementSystem
{
    internal class Employee
    {
        int EmpId;
        string Name;

        // Method
        // public = Access Modifier
        // void = return type
        // (int id, string name) = parameters, or messages
        public void Add(int id, string name)
        {
            EmpId = id;
            Name = name;
        }

        // Method
        // private = Access Modifier
        // int = return type
        // () = NO parameters, or messages
        private int GetId()
        {
            return EmpId;
        }
    }
}
