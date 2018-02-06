using System;
using System.Collections.Generic;

namespace FizzBuzzConsoleProject
{
	public class Solution
	{
		public IList<string> FizzBuzz(int n)
		{
			/* Creates a list of n items, where every integer:
			 * 	- divisible by 3 is replaced with "Fizz",
			 * 	- divisible by 5 is replaced with "Buzz,
			 *  - divisible by both 3 & 5 is replaced with "FizzBuzz
			 *  - not divisible by either will just be the integer
			 * 
			 * type	n	:	integer
			 * rtype	:	IList<string>
			*/

			// Case: Check if input is 0
			if (n == 0)
			{
				return [0];
			}

			// Create an IList to add items to
			List<string> fizzBuzzList = new List<string>();

			// Loop through the range of 0,n
			for (int i = 1; i <= n; i++)
			{
				// Check if the number is divisible by both 3 & 5
				if (i % 15 == 0)
				{
					fizzBuzzList.Add("FizzBuzz");
					continue;
				}
				else if (i % 3 == 0)
				{
					fizzBuzzList.Add("Fizz");
					continue;
				}
				else if (i % 5 == 0)
				{
					fizzBuzzList.Add("Buzz");
					continue;
				}
				else
				{
					fizzBuzzList.Add(i.ToString());
					continue;
				}
			}

			return fizzBuzzList;
		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Intro print
			Console.WriteLine("----\tFizzBuzz\t----\n");

			// Create an instance of the solution class
			Solution sol = new Solution();

			// Ask the user to input an integer
			Console.Write("Please enter an integer: ");
			// Get the user input
			int usrInput = Int32.Parse(Console.ReadLine());

			IList<string> ans = sol.FizzBuzz(usrInput);

			// Loop through items in list
			for (int i = 0; i < ans.Count; i++)
			{
				Console.WriteLine(ans[i]);
			}
		}
	}
}
