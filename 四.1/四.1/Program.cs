﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            bool s;
            x = y = z = 0;
            s = x++ != 0 || ++y != 0 && ++y != 0;
            Console.WriteLine("x={0},y={1},z={2},s={3}", x, y, z, s);
            Console.Read();
        }
    }
}
