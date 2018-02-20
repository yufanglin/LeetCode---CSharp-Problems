using System;

namespace HammingDistanceCP
{
	public class Solution
	{
		public int HammingDistance(int x, int y)
		{
			/*
			 * Find the Hamming Distance between x and y
			 * type	x 	:	int
			 * type	y	:	int
			 * rtype	:	int
			*/

			// Check if x and y have the same value
			if (x == y)
			{
				return 0;
			}

			// Create a variable to store the distance
			int dist = 0;

			// Get the number with all the bits different from x and y
			int diff = x ^ y;
			// Console.WriteLine("Initial diff: {0}", diff);

			// Loop until diff reaches 0
			while (diff != 0)
			{
				// Increment dist
				dist++;
				diff &= diff - 1;
				// Console.WriteLine("Current diff: {0}", diff);
			}

			// Return the distance
			return dist;
		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create an instance of the solution class
			Solution sol = new Solution();

			// Get user input for x
			Console.Write("\nEnter x: ");
			int x = Int32.Parse(Console.ReadLine());

			// Get user input for y
			Console.Write("\nEnter y: ");
			int y = Int32.Parse(Console.ReadLine());

			// Get the Hamming Distance
			int hammingDist = sol.HammingDistance(x, y);

			// Print out solution
			Console.WriteLine("\nHamming Distance: {0}", hammingDist);

		}
	}
}
