using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_8
{
    class Program
    {
        static void Main()
        {
            int[] mass = new int[15];
            Random rnd = new Random();
            for (int x = 0; x < mass.Length; x++)
            {
                mass[x] = rnd.Next(0, 19);
                Console.Write(mass[x] + " ");
            }
            Console.WriteLine();

            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int x = 0; x < mass.Length; x++)
            {
                if (mass[x] >= 0 && mass[x] <= 4)
                { sum++; }

                else if (mass[x] >= 5 && mass[x] <= 9)
                { sum1++; }

                else if (mass[x] >= 10 && mass[x] <= 14)
                { sum2++; }

                else if (mass[x] >= 15 && mass[x] <= 19)
                { sum3++; }
            }

            Console.WriteLine("Электрического типа: " + sum);
            Console.WriteLine("Водяного типа: " + sum1);
            Console.WriteLine("Земляного типа: " + sum2);
            Console.WriteLine("Огненного типа: " + sum3);
            Console.ReadKey();
        }      
    }
}
