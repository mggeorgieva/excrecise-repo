using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.SMSTyping
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var num = Console.ReadLine();
                char letter = ' ';
                if (num != "0")
                {
                    var mainDigit = int.Parse(num[0].ToString());
                    var offset = (mainDigit - 2) * 3;
                    var letterIndex = offset + num.Length - 1;
                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        letterIndex++;
                    }
                    letter = (char)(letterIndex + 'a');
                }
                Console.Write(letter);
            }
        }
    }
}
