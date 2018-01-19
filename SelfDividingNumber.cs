using System;
using System.Collections.Generic;

namespace selfDivingNumber
{
	public class BetterSolution
	{
		public IList<int> SelfDividingNumbers(int left, int right)
		{
			List<int> selfDrivingNum = new List<int>();

			for (int i = left; i <= right; i++)
			{
				bool IsValid = ValidateSelfDrivingNum(i);

				if (IsValid)
				{
					selfDrivingNum.Add(i);
				}
			}

			return selfDrivingNum;   
		}

		public bool ValidateSelfDrivingNum(int num)
		{
			int currentNumber = num;
			List<int> digits = new List<int>();
			while (currentNumber != 0)
			{
				if (currentNumber % 10 == 0)
				{
					return false;
				}
				else if (num % (currentNumber % 10) != 0)
				{
					return false;
				}
				currentNumber = currentNumber / 10;
			}

			return true;
		}
	}
	public class Solution
	{
		public IList<int> SelfDividingNumbers(int left, int right)
		{
			/// Creates a list of integers that can divide itself 
			/// 
			/// type left	: int
			/// type right	: int
			/// rtype		: IList<int>
			/// 


			IList<int> selfDivingNumList = new List<int>();

			// Loop through the lower to upper bounds to check create a list
			for (int i = left; i <= right; i++)
			{
				// First check if the number is divisible by 10, if so, go to next index
				if (i % 10 != 0)
				{
					// Check if the number is divisible by its digits
					if (DivisibleByItself(i))
					{
						// Add the number to the list
						selfDivingNumList.Add(i);
					}
				}
			}


			return selfDivingNumList;
		}

		public bool DivisibleByItself(int num)
		{
			/// Checks if an integer can divide itself with its digits
			/// 
			/// type num	: int
			/// rtype		: bool
			/// 

			// get an array of the number's digits
			int[] digitArray = IntToDigitCollection(num).ToArray();

			// loop through the digit array
			for (int i = 0; i < digitArray.Length; i++)
			{
				// Check if the digit is 0, if so, return false
				if (digitArray[i] == 0)
				{
					return false;
				}
				// Check if the number CANNOT be divided by its digit
				if (num % digitArray[i] != 0)
				{
					return false;
				}
			}

			return true;
		}

		public Stack<int> IntToDigitCollection(int num)
		{
			/// Converts an integer to a collection of its digits
			/// 
			/// type num	: int
			/// rtype		: Stack<int>
			/// 
			/// from: 
			/// https://stackoverflow.com/questions/829174/is-there-an-easy-way-to-turn-an-int-into-an-array-of-ints-of-each-digit
			/// 

			// Check if the integer is 0, if so, return an empty stack
			if (num == 0)
			{
				return new Stack<int>();
			}

			// Divide the number value to get a each digit
			var numbers = IntToDigitCollection(num / 10);

			// Add the remainder to numbers
			numbers.Push(num % 10);

			return numbers;
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create an instance of the solution class
			Solution sol = new Solution();

			// Get the left and right bounds from the user
			Console.Write("Enter the lower boundary: ");
			int left = Int32.Parse(Console.ReadLine());

			Console.Write("Enter the upper boundary: ");
			int right = Int32.Parse(Console.ReadLine());

			// Get the array of self dividing numbers from the solution
			IList<int> ans = sol.SelfDividingNumbers(left, right);

			Console.WriteLine("Self-Diving numbers from {0} to {1}: {2}", left, right, ans);
		}
	}
}
