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
            int i = 0, totalprice = 0;
            int price = 0;

            while (i < 150)
            {
                Console.Write("quanto você gastou :");
                price = int.Parse(Console.ReadLine());
                totalprice = totalprice + price;
                i++;
            }
            Console.WriteLine("receita total :" + totalprice);
        }

        }
}
