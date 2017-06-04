using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Round(1.45, 1));
            double bpm = double.Parse(Console.ReadLine());
            double beats = double.Parse(Console.ReadLine());
            double bars = Math.Round((beats / 4), 1);
            double seconds = (int)((beats / bpm) * 60);

            int minutes = (int)(seconds / 60);
            double seconds1 = seconds % 60;

            Console.WriteLine("{0} bars - {1}m {2}s", bars, minutes, seconds1);
        }
    }
}
