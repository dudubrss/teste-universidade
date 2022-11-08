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
            int[] vetor = new int[6];
            for (int i = 0; i < 6; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
