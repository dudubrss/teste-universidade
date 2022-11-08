using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace estudos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] arrayA = new double[10];
            double[] arrayM = new double[10];
            double x;
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.Write("digite um numero :");
                arrayA[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("digite o numero do x :");
            x = double.Parse(Console.ReadLine());
            for (int i = 0; i < arrayM.Length; i++)
            {
                arrayM[i] = arrayA[i] * x;
                Console.WriteLine(arrayM[i]);

            }
        }
    }
}
