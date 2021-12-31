using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day5Demos
{

    class Tree
    {
        int totalLeaves;
        List<string> nameOfAllAnimalsLivingOnTree;

        public Tree(int leaves)
        {
            totalLeaves = leaves;
            nameOfAllAnimalsLivingOnTree = new List<string>();
        }

        public void AddAnimalName(string nameOfAnimal)
        {
            nameOfAllAnimalsLivingOnTree.Add(nameOfAnimal);
        }

        public void Display()
        {
            // Question: 1 Major Difference between the two string methods, SubString and Join
            // Using concept learnt in class today
            // Answer: Substring is a Instance Member
            // Join is a static member
            //string s = "Who goes there";
            //Console.WriteLine(s.Substring(5, 3));

            // We dont need a forloop to display comma separated array values
            //Console.Write($"TotalLeaves={totalLeaves}, Names=");
            //foreach (string name in nameOfAllAnimalsLivingOnTree)
            //{
            //    Console.Write(name + ",");
            //}

            string namesText = string.Join(",", nameOfAllAnimalsLivingOnTree);
            Console.Write($"TotalLeaves={totalLeaves}, Names=[{namesText}]");

            Console.WriteLine();
        }

        // Destructor
        // Called automatically by the program, when the object is destroyed
        // i.e. when the garbage collection comes along to destroy your object.
        // You cannot know when this will happen, so you cannot depend on writing any dependent code in the destructor
        ~Tree()
        {
            Console.WriteLine("Destroying the object");
            nameOfAllAnimalsLivingOnTree = null;
        }
    }

    internal class Demo3Destructor
    {
        public static void Test()
        {
            Tree t = new Tree(100);
            t.AddAnimalName("Chimpmunk Pete");
            t.AddAnimalName("Sloth Bear Robert");

            t.Display();
        }
    }
}
