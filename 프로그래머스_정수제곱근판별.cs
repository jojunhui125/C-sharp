using System;

public class Solution
{
	public long solution(long n)
	{
		long answer = 0;

		for (long i = 1; i <= n; i++)
		{
			if (i * i == n)
			{
				answer = (i + 1) * (i + 1);
				break;
			}
			else if (i * i >= n)
			{

				break;
			}

		}
		if (answer == 0)
		{
			return -1;
		}
		return answer;

	}
}