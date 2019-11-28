﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace four_7
{
    public class Test
    {
        public void change1(string s)
        {
            s = s + "Change1";
        }
        public void change2(ref string s)
        {
            s = s + "Change2";
        }
        public void change3(string s1, out string s2)
        {
            s1 = s1 + "Change3";
            s2 = s1;
        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            string s1, s2;
            s1 = "Hello,";
            Test t1 = new Test();
            t1.change1(s1);
            Console.WriteLine("s1 after call to change1 is {0}", s1);
            t1.change2(ref s1);
            Console.WriteLine("s1 after call to change2 is {0}", s1);
            t1.change3(s1,out s2);
            Console.WriteLine("s1 after call to change3 is {0}", s1);
            Console.WriteLine("s2 after call to change3 is {0}", s2);
            Console.Read();
        }
    }
}
