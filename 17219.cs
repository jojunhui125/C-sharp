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
			StringBuilder builder = new StringBuilder();
			StreamWriter wr = new StreamWriter(OpenStandardOutput());
			StreamReader rd = new StreamReader(OpenStandardInput());

			string[] input = rd.ReadLine().Split();
			int n = int.Parse(input[0]);
			int m = int.Parse(input[1]);
			Dictionary<string, string> map = new Dictionary<string, string>();

			for (int i = 0; i < n; i++)
			{
				input = rd.ReadLine().Split();
				map.Add(input[0], input[1]);
			}
			string email;
			for (int j = 0; j < m; j++)
			{
				email = rd.ReadLine();
				builder.Append($"{map[email]}\n");
			}

			wr.WriteLine(builder);
			wr.Close();
			rd.Close();
		}
	}
}