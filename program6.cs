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
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("digite o numero :");
                array[i] = int.Parse(Console.ReadLine());
            }
            int answer = A(array);
            Console.WriteLine("soma dos números impares :{0}", answer);
        }
        public static int A(int[] vetor)
        {
            int answer = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 1)
                {
                    answer = answer + vetor[i];
                }
            }
            return answer;
        }
    }
}
