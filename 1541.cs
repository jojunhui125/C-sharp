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
			string input = ReadLine();
			string[] number = input.Split('-');
			int n = 0;
			


			
			foreach(string strnumber in number[0].Split('+'))
			{
				n += int.Parse(strnumber);
			}

			if(number.Length==0)
			{
				WriteLine(n);
			}
			else
			{
				for (int i = 1; i < number.Length; i++)
				{
					string[] newinput = number[i].Split('+');

					foreach (string num in newinput)
					{
						n -= int.Parse(num);
					}
				}

			}
			
			WriteLine(n);
			
		}

	
		


	}

}
