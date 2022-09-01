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
			int n = int.Parse(ReadLine());
			List<int> nlist = Array.ConvertAll(ReadLine().Split(), s => int.Parse(s)).ToList();
			nlist.Sort();
			int m = int.Parse(ReadLine());
			List<int> mlist = Array.ConvertAll(ReadLine().Split(), s => int.Parse(s)).ToList();
			StringBuilder result = new StringBuilder("");

			for (int i = 0; i < m; i++)
			{
				int start = 0;
				int end = n - 1;
				int check = 0;

				while (start <= end)
				{
					int middle = (start + end) / 2;

					if (nlist[middle] == mlist[i])
					{
						check = 1;
						break;
					}
					else if (nlist[middle] > mlist[i])
					{
						end = middle - 1;
					}
					else
					{
						start = middle + 1;
					}
				}
				result.Append(check + "\n");
			}
			WriteLine(result);
		}

	}
}

// 1 2 3 4 5
// 1 3 5 7 9
// 1 1 1 0 0