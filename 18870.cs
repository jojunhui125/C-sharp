using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;
using System.Threading;
using System.IO;

namespace project
{


	public class Program
	{
		public static int LowerBound(int target, int[] datafile, int len)
		{
			int left = 0;
			int right = len - 1;
			int middle;
			while (left < right)
			{
				middle = (left + right) / 2;
				if (datafile[middle] >= target)
				{
					right = middle;
				}
				else
				{
					left = middle + 1;
				}
			}
			return right;
		}
		public static void Main(string[] args)
		{
			int N = int.Parse(ReadLine());
			string temp = ReadLine();
			string[] arr = temp.Split();

			int[] number = Array.ConvertAll(arr, int.Parse);
			int[] data = Array.ConvertAll(arr.Distinct().ToArray(), int.Parse);
			Array.Sort(data);

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < number.Length; i++)
			{
				sb.Append(LowerBound(number[i], data, data.Length) + " ");
			}
			WriteLine(sb.ToString());

		}


		// 2 4 -10 4 -9   => number					example input = 2 4 -10 4 9
		// -10 -9 2 4 9   => data						example output = 2 3 0 3 1
		// number[0]=2 -> target
		// data[middle] -> data[2] -> 2
		// right=middle  right=2
		// middle =1 
		// data[1]= -9 target=2
		// left=middle+1   =>   2
		// while break;  => return right=2
		// first Write => 2


	}

}
