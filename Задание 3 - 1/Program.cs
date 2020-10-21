using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3___1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int y = 0; y < 10; y++)
            {
                array[y] = rnd.Next(1, 12);
                Console.Write(array[y] + " ");
            }
            
            Console.ReadKey();
        }
    }
}
