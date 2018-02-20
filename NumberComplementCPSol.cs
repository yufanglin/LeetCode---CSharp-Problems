using System;

namespace NumberComplementCP
{
	public class Solution
	{
		public int FindComplement(int num)
		{
			/*
			 * Find the complement of a number
			 * type	num		:	int
			 * rtype		:	int
			*/

			// create a tracker copy of the number
			int onesTracker = num;
			// Create a storage for an integer whose binary is the leftmost 1 of num's binary
			int lastOneOfNum = 0;

			// loop until the tracker copy reaches 0 (because binary version will have no 1's)
			while (onesTracker != 0)
			{
				// We eventually want to find the number whose binary version has only one '1' left
				lastOneOfNum = onesTracker;
				Console.WriteLine("Current lastOneOfNum: {0}", lastOneOfNum);
				// remove the far right 1 from binary version of the integer
				onesTracker &= onesTracker - 1;
				Console.WriteLine("Current n: {0}", onesTracker);
			}

			// Get the number whose binary version is made out of 1's
			// Do this by shifting the binary version of lastOneOfNum to the left by one bit.
			// Then subtract lastOneOfNum with 1, which will change all the 0's to 1, 
			// since lastOneOfNum had only one far left 1. Lastly, find the binary difference between that number and num, 
			// this is our complement
			// for ex: 	num = 5 (101), lastOneOfNum = 4 (100)
			// 			shifting lastOneOfNum to the left = 8 (1000)
			// 			Subtracting by one: 8 (1000) - 1 (0001) = 7 (111)
			//			Difference between 5 (101) and 7 (111) is 2 (010)
			return num ^ ((lastOneOfNum << 1) - 1);
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create an instance of the Solution class
			Solution sol = new Solution();

			// Get a number from the user
			Console.Write("Enter an number: ");
			int num = Int32.Parse(Console.ReadLine());

			// Get the complement
			int complement = sol.FindComplement(num);

			// Print out solution
			Console.WriteLine("Complement: {0}", complement);
		}
	}
}
