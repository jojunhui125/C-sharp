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
            string[] input = Console.ReadLine().Split();

            if (int.Parse(input[0]) ==1 )
            {
                for(int i = 1; i <=8; i++)
                {
                    if (int.Parse(input[i-1]) != i )
                    {
                        Console.WriteLine("mixed");
                        return;
                    }
                    
                    
                }
                Console.WriteLine("ascending");

            }
            else if(int.Parse(input[0]) == 8)
            {
                int cnt = 8;
                for (int i = 1; i <=8; i++)
                {
                    if (int.Parse(input[i - 1]) != cnt)
                    {
                        Console.WriteLine("mixed");
                        return;
                    }
                    cnt--;

                }
                Console.WriteLine("descending");
            }
            else
            {
                Console.WriteLine("mixed");
            }
            

            


        }
    }
}
