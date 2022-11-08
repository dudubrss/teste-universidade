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
            int alunos = 0;
            double media, total = 0;
            int[] notas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("escreva sua nota :");
                notas[i] = int.Parse(Console.ReadLine());
                total = total + notas[i];
            }
            media = total / 10;
            for (int i = 0; i < 10; i++)
            {
                if (media < notas[i])
                {
                    alunos++;
                }
            }
            Console.WriteLine("media da turma :{0}", media);
            Console.WriteLine("resultado :{0} alunos", alunos);
        }
    }
}
