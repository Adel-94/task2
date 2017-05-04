using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int gunlukgelir;
            int gunsayi;
            double faiz;
            double netgelir;
            Console.Write("gunluk geliri daxil et:");
            gunlukgelir = int.Parse(Console.ReadLine());
            Console.Write("gun sayini daxil et:");
            gunsayi = int.Parse(Console.ReadLine());
            int brutgelir = gunlukgelir * gunsayi;
             if (brutgelir >= 1000)
            {
                faiz = brutgelir * 0.18;
            }
             else
            {
                faiz = brutgelir * 0.04;
            }
            netgelir = brutgelir - faiz;
            Console.Write("faiz = " + faiz + "\n" + "netgelir = " + netgelir);
            Console.ReadLine();

        }
      
    }
}
