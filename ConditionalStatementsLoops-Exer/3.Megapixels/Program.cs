using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = long.Parse(Console.ReadLine());
            double height = long.Parse(Console.ReadLine());
            Console.WriteLine("{0}x{1} => {2}MP", width, height, Math.Round((width * height) / 1000000, 1));
        }
    }
}
