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
            uint[] arrayQ = new uint[10];
            uint max;
            int element;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("digite um numero :");
                arrayQ[i] = uint.Parse(Console.ReadLine());
            }
            max = arrayQ.Max();
            element = Array.IndexOf(arrayQ, max);

            Console.WriteLine("maior valor :{0}", max);
            Console.WriteLine("O element :{0}", element);
        }
    }
}
