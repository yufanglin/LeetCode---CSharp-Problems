using System;

namespace JudgeRouteCircleCP
{
	public class Solution
	{
		public bool JudgeCircle(string moves)
		{
			/*
			 * Checks if the moves lead back to the original position
			 * type moves    : str
			 * rtype			: bool
			*/

			// Create a counter for horizontal and vertical movements
			int verticalMov = 0;
			int horizontalMov = 0;

			// loop through the movements
			foreach (char move in moves)
			{
				switch (move)
				{
					case 'U':
						verticalMov += 1;
						break;
					case 'R':
						horizontalMov += 1;
						break;
					case 'D':
						verticalMov -= 1;
						break;
					case 'L':
						horizontalMov -= 1;
						break;
					default:
						Console.WriteLine("Improper input");
						break;
				}
			}

			return (verticalMov == 0 && horizontalMov == 0);
		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create an instance of the solution class
			Solution sol = new Solution();

			// Create an intro message to output to users
			string introMsg = @"-------- Judge Route: Circle --------
Program check if entered route's ending position matches
the starting point
	Instructions: 
		Enter the route as a string of 
			- U (UP), R (Right), D (Down), L (Left)
		Example: 'UD' is a route that goes up, then down";

			// Output the intro message
			Console.WriteLine(introMsg);

			// Ask the user to input a route
			Console.Write("\nPlease Input a route: ");
			string route = Console.ReadLine();

			// Judge the route
			bool ans = sol.JudgeCircle(route);

			// Print output based on answer
			if (ans)
			{
				Console.WriteLine("The route is a loop");
			}
			else
			{
				Console.WriteLine("The route is NOT a loop");
			}
		}
	}
}
