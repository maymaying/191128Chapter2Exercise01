using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five._1
{
    class Program
    {
        public int[] GetData()
        {
            int num = 0;//计数器
            int[] array = new int[30];
            array[0] = 1;//第一个数赋值
            array[1] = 1;//第二个数赋值
            for (int i = 2; i < 30; i++)
            {
                //输出第3个到第30个数的数值
                array[i] = array[i - 1] + array[i - 2];

            }
            foreach (int u in array)
            {
                Console.Write(u + ",");
                num++;
                if (num == 5)
                {
                    Console.WriteLine();
                    num = 0;
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            Program st = new Program();

            st.GetData();

            Console.ReadLine();

        }
    }
}
