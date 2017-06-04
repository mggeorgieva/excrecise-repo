using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sumInput = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            for (int i = a; i > 0; i--)
            {
                for (int j = 1; j <= b; j++)
                {
                    counter++;
                    sum += (3 * (i * j));
                    // Console.WriteLine($"{i} {j}");
                    if (sum >= sumInput)
                    {
                        Console.WriteLine("{0} combinations", counter);
                        Console.WriteLine("Sum: {0} >= {1}", sum, sumInput);
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations", counter);
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
