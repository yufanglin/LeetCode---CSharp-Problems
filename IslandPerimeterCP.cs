using System;

namespace IslandPerimeterCP
{
	/*
	 * Island Perimeter
	 * Yufang Lin
	 * My solution to the leetCode problem: "Island Perimeter",
     * https://leetcode.com/problems/island-perimeter/description/
	*/
	public class Solution
	{
		public int IslandPerimeter(int[,] grid)
		{
			/*
			 * Find the perimeter of an island.
			 * The grid is made out of 0's and 1's.
			 * Each 1 is an land cell that has four 1 length sides.
			 * 
			 * type grid 	: int[,]
			 * rtype		: int
			*/

			// create a storage to for the perimeter
			int perimeter = 0;

			// first loop through all the rows (arrays)
			for (int row = 0; row < grid.GetLength(0); row++)
			{
				// Second, loop through all the columns (elements in each row)
				// get the length of the second dimension (each row length)
				for (int col = 0; col < grid.GetLength(1); col++)
				{
					// Check if the element is ocean
					if (grid[row, col] == 0)
					{
						// if so, continue to the next element
						continue;
					}
					// check if the land cell's top is connected to water or out of bounds
					if (row - 1 == -1 || grid[row - 1, col] == 0)
					{
						perimeter++;
					}
					// Check if the land cell's right is connected to water or out of bounds
					if (col + 1 == grid.GetLength(1) || grid[row, col + 1] == 0)
					{
						perimeter++;
					}
					// check if the land cell's bottom is connected to water or out of bounds
					if (row + 1 == grid.GetLength(0) || grid[row + 1, col] == 0)
					{
						perimeter++;
					}
					// check if the land cell's left is connected to water or out of bounds
					if (col - 1 == -1 || grid[row, col - 1] == 0)
					{
						perimeter++;
					}
				}
			}
					              
			return perimeter;
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create an instance of the solution class
			Solution sol = new Solution();

			// Create an example to test
			int[,] grid = new int[4, 4] { {0,1,0,0}, {1,1,1,0}, {0,1,0,0}, {1,1,0,0} };

			// Find the perimeter of the island
			int perimeter = sol.IslandPerimeter(grid);

			// print out the solution
			Console.WriteLine("Island Perimeter: {0}", perimeter);
		}
	}
}
