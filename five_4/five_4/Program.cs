using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数");
            string word = Console.ReadLine();
            for (int i = word.Length - 1; i > -1; i--)
            {
                Console.Write(word[i]);
            }
            Console.Read();

        }
    }
}
