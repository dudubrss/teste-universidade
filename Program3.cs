using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("digite um numero :");
                array[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 9; i >= 0; i--)
            {

                Console.WriteLine(array[i]);
            }
    }
}
