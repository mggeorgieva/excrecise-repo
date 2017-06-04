using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            if (end - start >= 5)
            {
                for (int i = start; i <= end - 4; i++)
                {
                    for (int j = i + 1; j <= end - 3; j++)
                    {
                        for (int k = j + 1; k <= end - 2; k++)
                        {
                            for (int l = k + 1; l <= end - 1; l++)
                            {
                                for (int p = l + 1; p <= end; p++)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {p}");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
