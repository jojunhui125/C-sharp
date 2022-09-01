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

			if (N < 10)
			{
				if (N == 4 || N == 7 || N < 3)
				{
					WriteLine(-1);
				}
				else if (N % 5 == 0)
				{
					WriteLine(N / 5);
				}
				else if (N % 3 == 0)
				{
					WriteLine(N / 3);
				}
				else
				{
					WriteLine(2);
				}
			}
			else
			{
				if (N % 5 == 0)
				{
					WriteLine(N / 5);
				}
				else if ((N % 5) == 1 || (N % 5) == 3)
				{
					WriteLine(N / 5 + 1);
				}
				else if ((N % 5) == 2 || (N % 5) == 4)
				{
					WriteLine(N / 5 + 2);
				}

			}

		}

	}
}
