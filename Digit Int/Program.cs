using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_Int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nummer = 0, count = 0;
            Console.Write("Skrive Nummer :");
            nummer = Convert.ToInt32(Console.ReadLine());
            while (nummer > 0)
            {
                nummer = nummer / 10;
                count++;
            }
            Console.WriteLine("Nummer digit er : " + count);
            Console.ReadLine();
        }
    }
}
