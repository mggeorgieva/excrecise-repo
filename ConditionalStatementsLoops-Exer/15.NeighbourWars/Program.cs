using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main()
        {
            var pesho = int.Parse(Console.ReadLine());
            var gosho = int.Parse(Console.ReadLine());
            var goshoHealth = 100;
            var peshoHealth = 100;
            int counter = 0;
            while (goshoHealth > 0 && peshoHealth > 0)
            {
                counter++;
                if (counter % 2 != 0)
                {
                    goshoHealth = goshoHealth - pesho;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", counter);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);

                    }
                }
                else
                {
                    peshoHealth = peshoHealth - gosho;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", counter);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);
                    }
                }
                if (counter % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
            }
        }
    }
}
