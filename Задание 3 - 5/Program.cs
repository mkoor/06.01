using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3___5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string G = "1. Гриффиндор";
            //string S = "2. Слизерин";
            //string K = "3. Когтевран";
            //string P = "4. Пуффендуй";

            int[] mass = new int[4];
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(1,1000);
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();

            int max = mass.Max();
            int min = mass.Min();

            Console.WriteLine(max);
            Console.WriteLine(min);

            Console.ReadKey();

        }
    }
}
