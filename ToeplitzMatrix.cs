using System;

namespace ToeplitzMatrixCPSol
{
	/*
     * Toeplitz Matrix
     * Yufang Lin
     * 
     * My Solution to the leetCode problem called, "Toeplitz Matrix":
     * https://leetcode.com/problems/toeplitz-matrix/description/ 
    */

	public class Solution
	{
		public bool IsToeplitzMatrix(int[,] matrix)
		{
			/*
			 * Checks if every diagonal of a matrix from top-left 
			 * to bottom-right has the same int value.
			 * type matrix 	:	int[,]
			 * rtype 		:	bool
			*/

			// Loop through each array in the 2-dimensional array
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				// Loop through each element in each array, 
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					// Skip to the first row and first column since they are the lower bounds
					if (row > 0 && col > 0)
					{
						// Now Check if each element is NOT equal to the prev row's prev column value
						if (matrix[row - 1, col - 1] != matrix[row, col])
						{
							return false;
						}
						// else continue to the element
						continue;
					}
					// else continue to the next element
					continue;
				}
			}

			// Default to assuming the matrix is Toeplitz
			return true;
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create an instance of the Solution class
			Solution sol = new Solution();

			// -- Create matrix examples -- \\
			int[,] matrix1 = new int[,] {{1,2,3,4}, {5,1,2,3}, {9,5,1,2}};
			int[,] matrix2 = new int[,] { { 1, 2 }, { 2, 2 } };

			// Get the solution
			bool isToeplitz1 = sol.IsToeplitzMatrix(matrix1);
			bool isToeplitz2 = sol.IsToeplitzMatrix(matrix2);

			// Print out answers
			Console.WriteLine("Matrix1 is Toeplitz: {0}", isToeplitz1);
			Console.WriteLine("Matrix2 is Toeplitz: {0}", isToeplitz2);
		}
	}
}
