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
			int[] arr = Array.ConvertAll(ReadLine().Split(), int.Parse);
			int n = arr[0];
			int m = arr[1];

			long start = 0, end = 0;
			long[] number = Array.ConvertAll(ReadLine().Split(), s => long.Parse(s));

			Array.Sort(number);
			end = number[number.Length - 1];
			long middle;
			while (start <= end)
			{

				middle = (start + end) / 2;
				long len = 0;
				for (long i = n - 1; i >= 0; i--)
				{
					if (number[i] - middle > 0)
					{
						len += number[i] - middle;
					}
					else
					{
						break;
					}
				}
				if (len >= m)
				{
					start = middle + 1;

				}
				else
				{
					end = middle - 1;
				}
			}
			WriteLine(end);

		}

	}
}