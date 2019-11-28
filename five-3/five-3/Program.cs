using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=100;i<=999;i++)
            {
                 int geWei, shiWei, baiWei;
                 baiWei = i / 100;
                 shiWei = (i - baiWei * 100) / 10;
                 geWei = i - baiWei * 100 - shiWei * 10;
                if (i == geWei * geWei * geWei + shiWei * shiWei * shiWei + baiWei * baiWei * baiWei)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
