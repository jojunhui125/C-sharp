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



	class Program
	{


		static void Main(string[] args)
		{
			StringBuilder sb = new StringBuilder();
			string[] temp = ReadLine().Split();
			int m = int.Parse(temp[0]);
			int n = int.Parse(temp[1]);

			if (m == 1)
			{
				m++;
			}
			bool check = true;
			for (int i = m; i <= n; i++)
			{
				check = true;
				for (int j = 2; j * j <= i; j++)
				{
					if (j != i && i % j == 0)
					{
						check = false;
						break;
					}
				}

				if (check)
				{
					sb.AppendLine(i.ToString());
				}
			}

			Write(sb);

		}





	}
}