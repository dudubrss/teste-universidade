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
            double allGrades = 0, student = 15;
            double[] grades = new double[15];
            for (int i = 0; i < student; i++)
            {
                Console.Write("digite a nota :");
                grades[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < student; i++)
            {
                allGrades = allGrades + grades[i];
            }
            Console.WriteLine("média :" + (allGrades / student));
        }
        }
    }
}
