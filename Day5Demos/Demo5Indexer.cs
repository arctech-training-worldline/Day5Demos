using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos
{

    // Note: Real World we do not have public instance variables
    public class ClassRoomPeople
    {
        public List<string> students;
        public string teacher;

        public ClassRoomPeople(string teacher)
        {
            this.teacher = teacher;
            students = new List<string>();
        }

        internal void AddStudent(string studentName)
        {
            students.Add(studentName);
        }
    }

    public class ClassRoomPeopleRealWorld
    {
        // Note: Real World instance variables will be mostly private
        private List<string> students;
        private string teacher;

        public ClassRoomPeopleRealWorld(string teacher)
        {
            this.teacher = teacher;
            students = new List<string>();
        }

        internal void AddStudent(string studentName)
        {
            // Validation
            students.Add(studentName);
        }

        public string GetTeacherName()
        {
            return teacher;
        }

        public string GetStudentAt(int index)
        {
            return students[index];
        }

        // Indexer is just a alternate way of writing the above GetStudentAt function
        public string this[int index]
        {
            get
            {
                return students[index];
            }
        }
    }

    internal class Demo5Indexer
    {
        // Note: Real World we do not have public instance variables
        public static void TestIndexerWithPublicMemberVariables()
        {
            ClassRoomPeople classRoomPeople = new ClassRoomPeople("Mrs. Sudha Sharma");
            classRoomPeople.AddStudent("Master Raman Bhola");
            classRoomPeople.AddStudent("Miss Ruhi Chauhan");

            Console.WriteLine($"Teacher for this class is {classRoomPeople.teacher}");

            Console.WriteLine($"1st Student in class is {classRoomPeople.students[0]}");
            Console.WriteLine($"2nd Student in class is {classRoomPeople.students[1]}");

            // Note: Oh No the students array is empty
            classRoomPeople.students = new List<string>();
            classRoomPeople.AddStudent("Ha Ha I am a hacker!! I deleted all students");

            Console.WriteLine($"1st Student in class is {classRoomPeople.students[0]}");

            Console.WriteLine("**********************");
        }

        // Read World Example
        public static void TestIndexer()
        {
            ClassRoomPeopleRealWorld classRoomPeople = new ClassRoomPeopleRealWorld("Mrs. Sudha Sharma");
            classRoomPeople.AddStudent("Master Raman Bhola");
            classRoomPeople.AddStudent("Miss Ruhi Chauhan");

            Console.WriteLine($"Teacher for this class is {classRoomPeople.GetTeacherName()}");

            Console.WriteLine($"1st Student in class is {classRoomPeople.GetStudentAt(0)}");
            Console.WriteLine($"2nd Student in class is {classRoomPeople.GetStudentAt(1)}");
            Console.WriteLine("**********************");
        }

        public static void TestIndexer2()
        {
            ClassRoomPeopleRealWorld classRoomPeople = new ClassRoomPeopleRealWorld("Mrs. Sudha Sharma");
            classRoomPeople.AddStudent("Master Raman Bhola");
            classRoomPeople.AddStudent("Miss Ruhi Chauhan");

            Console.WriteLine($"Teacher for this class is {classRoomPeople.GetTeacherName()}");

            Console.WriteLine($"1st Student in class is {classRoomPeople[0]}");
            Console.WriteLine($"2nd Student in class is {classRoomPeople[1]}");
            Console.WriteLine("**********************");
        }
    }
}
