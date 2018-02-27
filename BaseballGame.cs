using System;
using System.Collections.Generic;

namespace BaseballGameCP
{
	public class Solution
	{
		/*
		 * Solution to the Baseball Game Problem on Leetcode:
         * https://leetcode.com/problems/baseball-game/description/
		*/

		public int CalPoints(string[] ops)
		{
			/*
			 * Takes a string array of valid/invalid scores and find the sum
             * Integer(one round's score): 	Directly represents the number of 
             * 							 	points you get in this round.
			 * "+" (one round's score): 	Represents that the points you get in 
			 * 								this round are the sum of the last two
			 * 								valid round's points.
			 * "D" (one round's score): 	Represents that the points you get in 
			 * 								this round are the doubled data of the 
			 * 								last valid round's points.
			 * "C" (an operation, which isn't a round's score): Represents the last
			 * 								valid round's points you get were invalid 
			 * 								and should be removed.
			 *
			 * type	ops 	: string[]
			 * rtype		: int
			*/

			// Check if the array is empty
			if (ops == null)
			{
				// no scores
				return 0;
			}

			// Create storage for valid scores
			List<int> validScores = new List<int>();

			// Create a storage for the sum
			int sum = 0;

			// loop through array
			for (int i = 0; i < ops.Length; i++)
			{
				// Check last input was valid
				if (ops[i] == "C")
				{
					int count = validScores.Count;
					// Check if there are any valid scores
					if (count > 0)
					{
						// Remove last valid score value from sum
						sum -= validScores[count - 1];

						// Remove the last valid score from the storage
						validScores.RemoveAt(count - 1);

						// continue to the next item in array
						continue;
					}

					// else continue to next score
					continue;
				}
				else if (ops[i] == "D")
				{
					int count = validScores.Count;
					// Check if there are any valid scores
					if (count > 0)
					{
						// Double the last valid score 
						int doubleScore = 2 * validScores[count - 1];
							
						// Add the score to the sum
						sum += doubleScore;

						// Add the score to the valid scores
						validScores.Add(doubleScore);

						// Continue to the next item in array
						continue;
					}

					// else continue to next score
					continue;
				}
				else if (ops[i] == "+")
				{
					int count = validScores.Count;
					// Check if there are any valid scores
					if (count > 0)
					{
						// Check if there are more than two scores
						if (count >= 2)
						{
							// Add the last two valid scores
							int sumOfLastTwo = validScores[count - 2] + validScores[count - 1];
							// add the last two valid scores
							sum += sumOfLastTwo;
							// Add the sum of the last two valid score as a valid score
							validScores.Add(sumOfLastTwo);

							continue;
						}
						else if (count == 1)
						{
							// add the last valid score to sum
							sum += validScores[count - 1];
							// Add the last valid score to storage
							validScores.Add(validScores[count - 1]);
							continue;
						}
					}

					// else continue to the next score
					continue;
				}
				else
				{
					// add the score to the sum
					sum += Int32.Parse(ops[i]);
					// add the score to the valid scores
					validScores.Add(Int32.Parse(ops[i]));
					continue;
				}
			}



			return sum;
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create an instance of the Solution class
			Solution sol = new Solution();

			// example scores
			string[] scoreSet1 = { "5", "2", "C", "D", "+" };
			string[] scoreSet2 = { "5", "-2", "4", "C", "D", "9", "+", "+" };

			// Get sum of both scores
			int sum1 = sol.CalPoints(scoreSet1);
			int sum2 = sol.CalPoints(scoreSet2);

	

			// Output the sum of the two score sets
			Console.WriteLine("Sum of score set 1: {0}", sum1);
			Console.WriteLine("Sum of score set 2: {0}", sum2);
		}
	}
}
