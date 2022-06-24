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

            string inputs = Console.ReadLine();
            string[] input = inputs.Split();
            int[] nums = Array.ConvertAll(input, int.Parse);
            int maxi = nums[0];
            int mini = nums[0];

            for (int i = 0; i < num; i++)
            {
                if (nums[i] < mini)
                {
                    mini = nums[i];
                }
                else if (nums[i] > maxi)
                {
                    maxi = nums[i];
                }
            }

            Console.WriteLine(mini + " " + maxi);

        }
    }
}
