using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_задание___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int s1 = 0;
            for (double i=20000; i<=5409314; i++)
            {
                if (i % 2 ==0) {s++;}
                else { s1++; }
               
            }
                Console.WriteLine("На концерт Alai Oli идут " + s + " человек");
                Console.WriteLine("На концерт Торба идут " + s1 + " человек");
            Console.ReadKey();
        }
    }
}
