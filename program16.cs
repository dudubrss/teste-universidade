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
            /*Em uma eleição presidencial, existem dois candidatos. Os votos são informados
            através de código. Os dados utilizados obedecem à seguinte codificação:
            1 e 2 = voto para os respectivos candidatos;
            3 = voto em branco;
            4 = voto nulo.
            Elabore um programa que calcule e escreva na tela:
            a) total de votos para cada candidato;
            b) total de votos brancos;
            c) total de votos nulos;
            d) total de votos lidos;
            e) mostre o candidato vencedor.*/
            int vote = 0, choice, candidate1 = 0, candidate2 = 0, blank = 0, votenull = 0;
            string winner;
            while (true)
            {
                Console.WriteLine("Digite o número" +
                    "\r\n1 :O primeiro candidato\r\n2 :O segundo candidato" +
                    "\r\n3 :Voto em branco\r\n5 :Finalizar");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    candidate1++;
                }
                else if (choice == 2)
                {
                    candidate2++;
                }
                else if (choice == 3)
                {
                    blank++;
                }
                else if (choice == 5)
                {
                    break;
                }
                else
                {
                    votenull++;
                }
                vote++;
            }
            if (candidate1 > candidate2)
            {
                winner = "O candidato1 e o vencedor.";
            }
            else
            {
                winner = "O candidato2 e o vencedor.";
            }
            Console.WriteLine("candidato1 :" + candidate1 + " votos\r\n"
                + "candidato2 :" + candidate2 + " votos\r\n" + "total de votos brancos :"
                + blank + "\r\ntotal de votos nulos :" + votenull + "\r\ntotal de votos lidos :"
                + vote + "\r\n" + winner);
        }

        }
}
