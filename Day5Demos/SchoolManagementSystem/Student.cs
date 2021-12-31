using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos.SchoolManagementSystem
{
    // public / internal
    // public: other projects/assemblies (.exe/.dll) can access this class
    // internal: only current project/assembly can access this class

    internal class Student
    {
        private int RollNo;
        public string Name;
        public int Age;

        protected internal int BadRemarksCount = 0;

        public const int MinAge = 4;
        public const int MaxAge = 50;

        public static int PassingScore;

        public void Add()
        {
            BadRemarksCount++;

            Console.WriteLine("Enter RollNo");
            string rollNoText = Console.ReadLine();
            RollNo = Convert.ToInt32(rollNoText);

            Console.WriteLine("Enter Age");
            string ageText = Console.ReadLine();
            Age = Convert.ToInt32(ageText);

            VerifyAge(Age);
        }

        private void VerifyAge(int a)
        {
            if (a < MinAge || a > MaxAge)
            {
                Console.WriteLine("Sorry you cannot enroll in this school");
            }
        }
    }

    // Inheritance
    class StudentV2 : Student
    {
        // Implicitly become properties because of inheritance
        //public int RollNo;
        //public string Name;
        //public int Age;

        public string FathersJob;
        public string MothersJob;
        public double AverageFamilyIncome;

        public void Add()
        {
            base.Add();

            Console.WriteLine("Enter FatherJob: ");
            FathersJob = Console.ReadLine();

            Console.WriteLine(PassingScore);
        }
    }
}
