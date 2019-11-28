using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace four_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 7, c = 5;
            switch (a > 0)
            {
                case true:
                    switch (b < 10)
                    {
                        case true:
                            Console.Write("^");
                            break;
                        case false:
                            Console.Write("!");
                            break;
                    }
                    break;
                case false:
                    switch (c == 10)
                    {
                        case false:
                            Console.Write("*");
                            break;
                        case true:
                            Console.Write("#");
                            break;
                    }
                    break;
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
