using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.VaporStore
{
    class Program
    {
        static void Main()
        {
            var money = double.Parse(Console.ReadLine());
            var games = Console.ReadLine();
            var spent = money;
            while (games != "Game Time")
            {
                if (games == "OutFall 4")
                {
                    if (money >= 39.99)
                    {
                        money = money - 39.99;
                        Console.WriteLine("Bought {0}", games);
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (games == "CS: OG")
                {
                    if (money >= 15.99)
                    {
                        money = money - 15.99;
                        Console.WriteLine("Bought {0}", games);
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (games == "Zplinter Zell")
                {
                    if (money >= 19.99)
                    {
                        money = money - 19.99;
                        Console.WriteLine("Bought {0}", games);
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (games == "Honored 2")
                {
                    if (money >= 59.99)
                    {
                        money = money - 59.99;
                        Console.WriteLine("Bought {0}", games);
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (games == "RoverWatch")
                {
                    if (money >= 29.99)
                    {
                        money = money - 29.99;
                        Console.WriteLine("Bought {0}", games);
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (games == "RoverWatch Origins Edition")
                {
                    if (money >= 39.99)
                    {
                        money = money - 39.99;
                        Console.WriteLine("Bought {0}", games);
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                games = Console.ReadLine();
            }
            if (money <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", spent - money, money);
            }
        }
    }
}
