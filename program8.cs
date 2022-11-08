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
            double celsius, fahrenheit;
            Console.Write("Celsius :");
            celsius = double.Parse(Console.ReadLine());
            fahrenheit = converTemp(celsius);
            Console.WriteLine("Fahrenheit :{0}", fahrenheit);
        }
        public static double converTemp(double celsius)
        {
            double fahrenheit;
            fahrenheit = (9 * celsius + 160) / 5;
            return fahrenheit;
        }
        }
    }
}
