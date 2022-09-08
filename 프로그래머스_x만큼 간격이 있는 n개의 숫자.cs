using System;
using System.Collections.Generic;

public class Solution
{
	public long[] solution(int x, int n)
	{
		List<long> answer = new List<long>();


		for (var i = 1; i <= n; i++)
		{
			answer.Add(i * x);
		}
		return answer.ToArray();
	}
}