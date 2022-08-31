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
			int number = Int32.Parse(ReadLine());

			Stack<int> stack = new Stack<int>();

			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < number; i++)
			{
				string[] input = ReadLine().Split();
				if (input[0] == "push")
				{
					stack.Push(Int32.Parse(input[1]));
				}

				else if (input[0] == "pop")
				{
					if (stack.Count == 0)
					{
						sb.AppendLine("-1");
					}
					else
					{
						sb.Append(stack.Pop() + "\n");

					}
				}

				else if (input[0] == "top")
				{
					if (stack.Count == 0)
					{
						sb.AppendLine("-1");
					}
					else
					{
						sb.Append(stack.Peek() + "\n");

					}

				}

				else if (input[0] == "size")
				{
					sb.Append(stack.Count + "\n");
				}

				else
				{
					if (stack.Count == 0)
					{
						sb.AppendLine("1");

					}
					else
					{
						sb.AppendLine("0");
					}
				}


			}
			Console.WriteLine(sb.ToString());


		}
	}
}