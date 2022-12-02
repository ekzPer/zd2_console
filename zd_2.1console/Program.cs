using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main()
        {
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            float y = float.Parse(Console.ReadLine());
            if (-23 < x && x < y && 0 > y && -23 < y)
                Console.WriteLine("внутри");
            else if (-23 > x || x > y || 0 < y || -23 > y)
                Console.WriteLine("вне");
            else Console.WriteLine("на границе");
        }
    }
}