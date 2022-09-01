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

		public static void Main(string[] args)
		{
			int[] input = Array.ConvertAll(ReadLine().Split(), int.Parse);

			int K = input[0];
			int N = input[1];

			long[] arr = new long[K];
			long start = 1;
			long end = 0;
			long max = 0;
			for (int i = 0; i < K; i++)
			{
				arr[i] = long.Parse(Console.ReadLine());
				if (arr[i] > end) end = arr[i];
			}

			while (start <= end)
			{
				long mid = (start + end) / 2;
				long cnt = 0;
				for (int i = 0; i < K; i++)
				{
					cnt += arr[i] / mid;
				}


				if (cnt >= N)
				{
					start = mid + 1;
					max = Math.Max(max, mid);
				}
				else end = mid - 1;
			}

			Console.WriteLine(max);
		}

	}
}