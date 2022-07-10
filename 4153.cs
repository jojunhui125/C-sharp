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
            while(true)
            {
                string[] input = Console.ReadLine().Split();

                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);

                if(a==0 && b==0 && c==0)
                {
                    break;
                }

               

                if(a*a + b*b == c*c)
                {
                    Console.WriteLine("right");
                    continue;
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }
            

           




        }
    }
}
