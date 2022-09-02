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
		public class Data
		{
			public int Start
			{
				get;set;
			}
			public int End
			{
				get; set;
			}
		}
		public static void Main(string[] args)
		{
			int N = int.Parse(ReadLine());
			Data[] data = new Data[N];

			for (int i = 0; i < N; i++)
			{
				int[] Time = Array.ConvertAll(ReadLine().Split(), s => int.Parse(s));
				data[i] = new Data
				{
					Start = Time[0],
					End = Time[1]
				};

			}
			var result = data.OrderBy(i => i.End).ThenBy(i => i.Start).Select(i => i).ToArray();
			int count = 0;
			int end_time = 0;
			for(int i=0;i<N;i++)
			{
				if(end_time<=result[i].Start)
				{
					end_time = result[i].End;
					count++;
				}
			}
			WriteLine(count);
		}

	}
}
