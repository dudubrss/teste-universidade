using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exfacul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double element;
            double[] arrayBefore = new double[10];
            double[] arrayAfter = new double[10];
            for (int i = 0; i < 10; i++)
            {
                arrayBefore[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                element = arrayBefore[i];
                arrayAfter[i] = element * element;
            }
            Console.WriteLine("Before");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arrayBefore[i]);
            }
            Console.WriteLine("After");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arrayAfter[i]);
            }
        }
    }
}
