using Day5Demos.SchoolManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoBitwiseOperators.TestSwapBits();

            //Demo5Indexer.TestIndexerWithPublicMemberVariables();            
            //Demo5Indexer.TestIndexer();

            //Demo4This.TestThis();

            //Demo3Destructor.Test();

            //Demo3CopyConstructor.Test();
            //Demo3CopyConstructor.TestCopyConstructor();

            //Demo2Constructors.Test();

            //Demo1.Test();

            //School school = new School();
            //school.Initialize();

            //// Constructor
            //Rocket rocket1 = new Rocket(200, 300, 50, 100);
            //rocket1.index = 1;
            //rocket1.AddGpsData(100);
            //rocket1.AddGpsData(200);

            //// Default constructor
            //Rocket rocket2 = new Rocket();
            //rocket2.index = 2;

            //// NO constructor
            //Rocket rocket3 = rocket1;
            //rocket3.index = 3;
            //rocket3.AddGpsData(300);

            //// Copy constructor
            //Rocket rocket4 = new Rocket(rocket1);
            //rocket4.index = 4;
            //rocket4.AddGpsData(400);            

            //if (Rocket.CompareRocketDimensions(rocket1, rocket2))
            //    Console.WriteLine("Rocket1 & Rocket2 are equal");
            //else
            //    Console.WriteLine("Rocket1 & Rocket2 are NOT equal");

            //Console.WriteLine("rocket1: " + rocket1.GetData());
            //Console.WriteLine("rocket2: " + rocket2.GetData());
            //Console.WriteLine("rocket3: " + rocket3.GetData());
            //Console.WriteLine("rocket4: " + rocket4.GetData());            
        }
    }
}
