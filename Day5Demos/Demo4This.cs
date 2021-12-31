using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demos
{
    public class Router
    {
        public int SignalRange;
        public bool Supports5Gz;
        public ConsoleColor Color;
        public string Brand;

        // "this" is used to differentiate between parameter name and instance name
        // as both have same Name
        public Router(int SignalRange, bool Supports5Gz, ConsoleColor Color, string Brand)
        {
            this.SignalRange = SignalRange;
            this.Supports5Gz = Supports5Gz;
            this.Color = Color;
            this.Brand = Brand;
        }

        internal void Display()
        {
            Console.WriteLine($"SignalRange={SignalRange}, Suppoprts5g={Supports5Gz}, Color={Color}, Brand={Brand}");
        }

        // This creates conflict
        //public Router(int SignalRange, bool Supports5Gz, ConsoleColor Color, string Brand)
        //{
        //    SignalRange = SignalRange;
        //    Supports5Gz = Supports5Gz;
        //    Color = Color;
        //    Brand = Brand;
        //}

        // You do not have to think of different names of parameters to avoid conflict.
        // See above
        //public Router(int range, bool supports, ConsoleColor c, string b)
        //{
        //    SignalRange = range;
        //    Supports5Gz = supports;
        //    Color = c;
        //    Brand = b;
        //}
    }

    internal class Demo4This
    {
        public static void TestThis()
        {
            Router r = new Router(1000, true, ConsoleColor.White, "NetGear Orbi");
            r.Display();

            Router r2 = new Router(2000, true, ConsoleColor.Black, "NetGear RX1001");
            r2.Display();
        }        
    }
}
