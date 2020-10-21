using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[7];
            Random rnd = new Random();
            for (int x = 0; x < mass.Length; x++)
            {
                mass[x] = rnd.Next(1, 31);
                Console.Write(mass[x] + " ");
            }

            int temp;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.ReadKey();

        }
    }
}
