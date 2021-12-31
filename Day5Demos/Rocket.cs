using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos
{
    internal class Rocket
    {
        public const int MaxFuel = 1000;

        public int index;
        int x, y;
        int width, height;
        List<int> gpsData = new List<int>();

        //public void SetDimensions(int paramX, int paramY, int paramWidth, int paramHeight)
        public Rocket(int paramX, int paramY, int paramWidth, int paramHeight)
        {
            x = paramX;
            y = paramY;
            width = paramWidth;
            height = paramHeight;
        }

        public Rocket()
        {
            x = 10;
            y = 10;
            width = 50;
            height = 100;
        }

        public Rocket(Rocket rocket)
        {
            x = rocket.x;
            y = rocket.y;
            width = rocket.width;
            height = rocket.height;

            foreach (int g in rocket.gpsData)
            {
                gpsData.Add(g);
            }
        }

        public static bool CompareRocketDimensions(Rocket rocket1, Rocket rocket2)
        {
            return rocket1.x == rocket2.x &&
                rocket1.y == rocket2.y &&
                rocket1.width == rocket2.height &&
                rocket1.height == rocket2.height;
        }

        public void AddGpsData(int newPoint)
        {
            gpsData.Add(newPoint);
        }

        public string GetData()
        {
            string gpsString = string.Join(",", gpsData);
            return $"x={x}, y={y}, width={width}, height={height}, gpsData={gpsString}";
        }

        public int this[int index]
        {
            get
            {
                return gpsData[index];
            }

            set
            {
                gpsData[index] = value;
            }
        }

        ~Rocket()
        {
            Console.WriteLine($"{index}) ~Rocket()");
        }
    }
}
