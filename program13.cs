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
            int x, y, soma;
            int[] vetor = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("digite um numero :");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("digite um numero do X:");
            x = int.Parse(Console.ReadLine());
            Console.Write("digite um numero do Y:");
            y = int.Parse(Console.ReadLine());
            soma = vetor[x - 1] + vetor[y - 1];
            Console.WriteLine("soma :" + soma);
        }
    }
}
