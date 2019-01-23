using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            while ( i<5)
            {
                i++;
                sum += i;
            }
            Console.WriteLine("sum IS {0}" , sum);
            Console.ReadLine();
            //C0730507 JAGROOP SINGH
        }
    }
}
