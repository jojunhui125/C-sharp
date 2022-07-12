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
            string[] num = Console.ReadLine().Split();

            int number = int.Parse(num[0]);
            int maxpoint = int.Parse(num[1]);

            
             List<int> input = new List<int> ();

             input = Console.ReadLine().Split().Select(Int32.Parse).ToList();
             input.Sort();
            int sum = 0;
           

            for(int i=0;i<number-2;i++)
            {
                if(sum==maxpoint)
                {
                    break;
                }
                for(int j=i+1;j<number-1;j++)
                {
                    if(sum==maxpoint)
                    {
                        break;
                    }
                    for(int k=j+1;k<number;k++)
                    {
                        if (input[i] + input[j] + input[k]>maxpoint)
                        {
                            break;
                        }
                        else
                        {
                            
                            if(input[i] + input[j] + input[k] <maxpoint && input[i] + input[j] + input[k] > sum)
                            {
                                sum = input[i] + input[j] + input[k];
                            }
                            

                        }

                    }
                }
             
            }
            Console.WriteLine(sum);


            

            

           




        }
    }
}
