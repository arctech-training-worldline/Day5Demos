using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos
{
    class Car
    {
        public ConsoleColor color;
        public int size;

        // OverLoaded Constructor
        public Car(ConsoleColor c, int s)
        {
            color = c;
            size = s;
        }

        // Copy
        public Car(Car car)
        {
            color = car.color;
            size = car.size;
        }

        public void Display()
        {
            Console.WriteLine($"Color={color}, Size={size}");
        }
    }

    internal class Demo3CopyConstructor
    {
        public static void Test()
        {
            Car c = new Car(ConsoleColor.Red, 100);
            c.Display();    // Red, 100

            Car d = c;            
            d.size = 500;

            c.Display();    // Red, 500
            d.Display();    // Red, 500
        }

        public static void TestCopyConstructor()
        {
            Car c = new Car(ConsoleColor.Red, 100);
            c.Display();    // Red, 100

            //Car d = c;
            Car d = new Car(c);
            d.size = 500;

            c.Display();    // Red, 100
            d.Display();    // Red, 500            
        }
    }
}
