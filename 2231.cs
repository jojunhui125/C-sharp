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
            int num = int.Parse(Console.ReadLine());

            int Sum = 0;
            int result = 0;

            for(int i=0;i<num;i++)
            {
                char[] charr = i.ToString().ToCharArray();

                for(int j=0;j<charr.Length;j++)
                {
                    Sum += int.Parse(charr[j].ToString());
                }
                result = Sum + i;

                if(result==num)
                {
                    Console.WriteLine(i);
                    break;
                }
                else if(i==num-1 && result!=num)
                {
                    Console.WriteLine(0);
                    break;
                }
                Sum = 0;
                
            }

            

           




        }
    }
}
