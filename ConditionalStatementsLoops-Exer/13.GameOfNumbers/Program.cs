using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            int x = 0;
            int y = 0;
            bool IsMagicEqual = false;
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    counter++;
                    sum = i + j;

                    if (sum == magic)
                    {
                        IsMagicEqual = true;
                        x = i;
                        y = j;
                    }
                }
            }
            if (IsMagicEqual)
            {
                Console.WriteLine($"Number found! {x} + {y} = {magic}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}
