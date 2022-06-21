using System;

namespace program
{
    class Program
    {
        
      
        static void Main(string[] args)
        {
            string answer = "";
            int n = int.Parse(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                string[] input = Console.ReadLine().Split();
                int number = int.Parse(input[0]);

                for(int j=0;j<input[1].Length;j++)
                {
                    for(int k=0;k<number;k++)
                    {
                        answer += input[1][j];
                    }
                }

                Console.WriteLine("{0}", answer);
                answer = "";

            }


        }
    }
}

