using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double subtotal = 0;
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());
                subtotal += price * itemCount;
                if (itemCount == 1)
                {
                    Console.WriteLine("Adding {0} {1} to cart.", itemCount, name);
                }
                else
                {
                    Console.WriteLine("Adding {0} {1}s to cart.", itemCount, name);
                }
            }
            Console.WriteLine("Subtotal: ${0:f2}", subtotal);
            if (budget - subtotal > 0)
            {
                Console.WriteLine("Money left: ${0:f2}", budget - subtotal);
            }
            else
            {
                Console.WriteLine("Not enough. We need ${0:f2} more.", subtotal - budget);
            }
        }
    }
}
