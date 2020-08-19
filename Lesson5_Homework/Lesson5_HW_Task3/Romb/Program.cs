using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    Console.Write("*");
                }
                for (int k = 0; k <= i; k--)
                {
                    Console.Write(" ");
                }
                // Перехід на новий рядок.
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
