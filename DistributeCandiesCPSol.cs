using System;
using System.Collections.Generic;

namespace DistributeCandiesCP
{
	/*
     * Distribute Candies
	 * Yufang Lin
	 * 
	 * My Solution to the "Distribute Candies" leetcode problem:
	 * "https://leetcode.com/problems/distribute-candies/description/"
	*/

	public class Solution
	{
		public int DistributeCandies(int[] candies)
		{
			/*
			 * Returns the max number of different kinds of 
			 * candies the sister of a brother-sister duo can gain
			 * 
			 * type candies: int[]
			 * rtype	   : int
			*/

			// create a hashset, since hashset can only have unique elements
			HashSet<int> uniqueCandies = new HashSet<int>();

			// loop through the candies
			foreach(int candy in candies)
			{
				// add the candy to the set, all non-unique will not be added
				uniqueCandies.Add(candy);
			}

			// Console.WriteLine(Math.Min(uniqueCandies.Count, candies.Length/2));
			// find the min between set's size and candy list size, this is our max 
			return Math.Min(uniqueCandies.Count, candies.Length/2);
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create an instance of the solution class
			Solution sol = new Solution();

			// Create examples to test the solution class
			int[] candies1 = {1, 1, 2, 2, 3, 3};
			int[] candies2 = {1,1,2,3};

			int maxKinds1 = sol.DistributeCandies(candies1);
			int maxKinds2 = sol.DistributeCandies(candies2);

			Console.WriteLine("Candy Set 1 Max Kinds: {0:D}", maxKinds1);
			Console.WriteLine("Candy Set 2 Max Kinds: {0:D}", maxKinds2);
		}
	}
}
