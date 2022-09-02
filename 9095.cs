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
			int N = int.Parse(ReadLine());
			int[] number = new int[12];
			number[1] = 1;
			number[2] = 2;
			number[3] = 4;

			int[] Case = new int[N];

			for (int i = 0; i < N; i++)
			{
				Case[i] = int.Parse(ReadLine());
			}

			for (int j = 0; j < Case.Length; j++)
			{
				for (int k = 4; k <= Case[j]; k++)
				{
					if (number[k] != 0) continue;
					number[k] = number[k - 1] + number[k - 2] + number[k - 3];
				}
				WriteLine(number[Case[j]]);
			}

		}






	}

}
