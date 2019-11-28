using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 1;
            for (double i = 1; i <= 1000; i++)
            {
                res *= (double)((2 * i) / (2 * i - 1)) * (double)((2 * i) / (2 * i + 1));
            }
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
