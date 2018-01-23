using System;

namespace MaxSumOfMinPairsCP
{
	public class Solution
	{
		public int ArrayPairSum(int[] nums)
		{
			/*
			 * Finds the maximum sum of min pairs
			 * 
			 * type	nums:	int[]
			 * rtype	:	int
			*/

			// Create a variable to hold the sum
			int sum = 0;

			// Sort the number array
			Array.Sort(nums);

			int i = 0;
			// loop through every even index of the number array
			while (i < nums.Length)
			{
				// add the min of each pair
				sum += nums[i];

				// increment index by two to get the min of each pair
				i += 2;
			}
				

			return sum;
		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create a Solution class 
			Solution sol = new Solution();

			// Get user input
			int[] testArray = { 1, 4, 3, 2 };

			int ans = sol.ArrayPairSum(testArray);

			Console.WriteLine("Max sum of min pairs: " + ans);
		}
	}
}
