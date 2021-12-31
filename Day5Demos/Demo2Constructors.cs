using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos
{
    class Plane
    {
        public int NumberOfEngines;
        public bool IsJetEngine;
        public int MinimumPilotsNeeded;
        public bool doesItFly;
        public string Description;

        public static ConsoleColor FixedColor;

        // Cumbersome to write a separate function, so overload the default constructor
        //public void Initialize()
        //{
        //    doesItFly = true;
        //    NumberOfEngines = 1;
        //    IsJetEngine = false;
        //    MinimumPilotsNeeded = 1;
        //}

        static Plane()
        {
            FixedColor = ConsoleColor.Blue;
        }

        /// <summary>
        ///  Constructor is a special function 
        ///  1. Same name as name of class
        ///  2. Does not have return type
        /// </summary>
        /// OverLoading the default constructor => constructor overloading
        public Plane()
        {
            doesItFly = true;
            NumberOfEngines = 1;
            IsJetEngine = false;
            MinimumPilotsNeeded = 1;
        }

        //public Plane(int, bool, int)
        public Plane(int numEngines, bool isJet, int minPilots)
        {
            doesItFly = true;
            NumberOfEngines = numEngines;
            IsJetEngine = isJet;
            MinimumPilotsNeeded = minPilots;
        }

        //public Plane(int)
        public Plane(int numEngines)
        {
            doesItFly = true;
            NumberOfEngines = numEngines;
            IsJetEngine = true;
            MinimumPilotsNeeded = 2;
        }

        public Plane(bool isJet)
        {
            doesItFly = isJet;
            NumberOfEngines = 1;
            IsJetEngine = true;
            MinimumPilotsNeeded = 2;
        }

        public void Display()
        {
            Console.WriteLine($"{Description} => DoesItFly={doesItFly}, pilots={MinimumPilotsNeeded}, engines={NumberOfEngines}, IsJetEngine={IsJetEngine}");
        }
    }

    internal class Demo2Constructors
    {
        public static void Test()
        {
            Plane cessna = new Plane();
            //cessna.Initialize();  // Cumbersome to write a separate function, so overload the default constructor

            cessna.Description = "CESSNA";
            cessna.Display();

            Plane boeing747 = new Plane();
            boeing747.Description = "BOEING 747";
            boeing747.Display();

            boeing747.NumberOfEngines = 4;
            boeing747.IsJetEngine = true;
            boeing747.MinimumPilotsNeeded = 3;

            boeing747.Display();

            Plane jumboTransport = new Plane(4, true, 4);
            jumboTransport.Description = "JUMBO MILITARY TRANSPORT";
            jumboTransport.Display();


            // Calling the different overloaded constructors
            Plane myPlane = new Plane(2);               // single parameter constructor
            Plane myPlane2 = new Plane(3);              // single parameter constructor
            Plane myPlane3 = new Plane();               // default constructor
            Plane myPlane4 = new Plane(5, false, 1);    // 3 parameter constructor
            Plane myPlane5 = new Plane(false);          // 1 parameter constructor
        }
    }
}
