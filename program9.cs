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
            int[] vetor = new int[10];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("入力 :");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < 0)
                {
                    vetor[i] = 0;
                }
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
        }
    }
}
