/*
 * 806. Number of Lines to Write String
 * Yufang Lin
 * 
 * My solution to the leetcode problem called, "Number of Lines To Write String":
 * https://leetcode.com/problems/number-of-lines-to-write-string/description/
*/

using System;

namespace NumOfLinesToWriteStringCP
{
	public class Solution
	{
		public int[] NumberOfLines(int[] widths, string S)
		{
			/*
			 * Find the number of lines it takes to write out string S
			 * type widths 	:	int[]
			 * type S		: 	string
			 * rtype 		: 	int[]
			*/

			// Create counters for width and lines
			int lineCount = 1;
			int widthCount = 0;

			// loop through the characters in the string 
			foreach ( char c in S.ToCharArray()) 
			{
				// find the width by getting the index of the char
				// for the widths array by subtracting char's unicode with
				// the a's unicode (since a is at index 0)
				int units = widths[c - 'a'];
				// Console.WriteLine("Index: {0}", c - 'a');

				// add units to current line's width count
				widthCount += units;

				// check to see if current line's width is over the max 100 
				// after adding on the curren't char's width
				if (widthCount > 100)
				{
					// increment lines
					lineCount++; 
					// place the current char's width to next line's width count
					widthCount = units;
				}

			}

			// return the line count and width count as an int array
			return new int[] {lineCount, widthCount};
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create an instance of the solution class
			Solution sol = new Solution();

			// Create two examples
			int[] widths1 = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10,10,10,10,10,10,10,10,10,10,10,10,10,10 };
			string S1 = "abcdefghijklmnopqrstuvwxyz";

			int[] widths2 = { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10,10,10,10,10,10,10,10,10,10,10,10,10,10 };
			string S2 = "bbbcccdddaaa";

			// Find the number of lines for each example
			int[] sol1 = sol.NumberOfLines(widths1, S1);
			int[] sol2 = sol.NumberOfLines(widths2, S2);

			// Print out solution
			Console.WriteLine("Example 1 - Number of Lines:{0} | Number of Units: {1}", sol1[0], sol1[1]);
			Console.WriteLine("Example 1 - Number of Lines:{0} | Number of Units: {1}", sol2[0], sol2[1]);
		}
	}
}
