using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for(int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                int cnt = 0;
                int plus = 1;
                

                for(int j=0; j < input.Length; j++)
                {
                    if(input[j] == 'O')
                    {
                        cnt += plus;
                        plus++;
                    }
                    else
                    {
                        plus = 1;
                    }
                }
                Console.WriteLine(cnt);
            }


            

            


        }
    }
}
