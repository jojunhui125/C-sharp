using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] num = new int[4];

            num[0] = a[3] - a[1];
            num[1] = a[1];
            num[2] = a[0];
            num[3] = a[2] - a[0];

            Console.WriteLine(num.Min());




        }
    }
}
