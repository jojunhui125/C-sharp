using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string a = "";
                int input = int.Parse(Console.ReadLine());

                if(input!=0)
                {
                    for(int j=input.ToString().Length-1; j>=0; j--)
                    {
                        a += input.ToString()[j];
                    }
                    if(a==input.ToString())
                    {
                        Console.WriteLine("yes");
                    }
                    else
                    {
                        WriteLine("no");
                    }
                }
                
                else if(input==0)
                {
                    break;
                }
                
            }
        }








    }

}
