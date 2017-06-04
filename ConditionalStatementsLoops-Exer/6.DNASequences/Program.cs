using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DNASequences
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            string[] nucleotides = new string[] { "A", "C", "G", "T" };
            var counter = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        counter++;
                        int sum = i + j + k;
                        if (counter % 4 == 1)
                        {
                            Console.WriteLine();
                        }
                        if (sum >= n)
                        {
                            Console.Write("O{0}{1}{2}O ", nucleotides[i-1], nucleotides[j-1], nucleotides[k-1]);
                        }
                        else
                        {
                            Console.Write("X{0}{1}{2}X ", nucleotides[i-1], nucleotides[j-1], nucleotides[k-1]);
                        }
                    }
                }
            }
        }
    }
}