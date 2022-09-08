using System;

public class Solution
{
	public bool solution(int x)
	{
		bool answer = true;
		int sum = 0;
		int num = x;
		while (x > 0)
		{
			sum += x % 10;
			x = x / 10;
		}
		if (num % sum == 0)
		{
			return answer;
		}
		else answer = false;


		return answer;
	}
}