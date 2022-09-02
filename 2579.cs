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
		static int[] max;
		static int[] input;
		public static void Main(string[] args)
		{
			int N = int.Parse(ReadLine());
			max = new int[N + 1];
			input = new int[N + 1];

			for (int i = 1; i <= N; i++)
			{
				input[i] = int.Parse(ReadLine());
			}
			max[1] = input[1];
			if (N > 1)
			{
				max[2] = input[1] + input[2];
			}


			WriteLine(Calc(N));
		}

		public static int Calc(int n)
		{

			if (n == 1 || n == 2)
			{
				return max[n];
			}
			for (int i = 3; i <= n; i++)
			{
				int ThreeStep = max[i - 3] + input[i - 1] + input[i];
				int TwoStep = max[i - 2] + input[i];

				max[i] = Math.Max(ThreeStep, TwoStep);
			}
			return max[n];

		}


	}

}
