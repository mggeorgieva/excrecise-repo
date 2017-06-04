using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class Program
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            var second = char.Parse(Console.ReadLine());
            var third = char.Parse(Console.ReadLine());
            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    for (int l = first; l <= second; l++)
                    {
                        if ((char)i != third && (char)j != third && (char)l != third)
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)l} ");
                        }
                    }
                }
            }
        }
    }
}
