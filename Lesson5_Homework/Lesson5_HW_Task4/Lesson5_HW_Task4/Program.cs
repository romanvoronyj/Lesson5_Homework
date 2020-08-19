using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_HW_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть висоту прямокутника:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть ширину прямокутника:");
            int width = int.Parse(Console.ReadLine());

            for (int a = 0; a < height; a++)
            {
                for(int b = 0; b < width; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
