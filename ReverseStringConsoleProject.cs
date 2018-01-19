using System;

namespace ReverseStringConsoleProject
{
	public class Solution 
	{
		public string ReverseString(string s) 
		{
			/*
			 * type s:	string
			 * rtype :	string
			 */

			// create left and right index trackers
			int l = 0;
			int r = s.Length - 1;

			// create an array of characters to hold the string
			char[] charArray = s.ToCharArray();

			while (l < r) 
			{
				// Create a temp to hold a character
				char t = charArray[l];
				charArray[l] = charArray[r];
				charArray[r] = t;
				l++;
				r--;
			}

			return new string(charArray);
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			Solution solution = new Solution();

			Console.Write("Enter a string to reverse: ");
			string strToReverse = Console.ReadLine();

			string reversedString = solution.ReverseString(strToReverse);
			Console.WriteLine("The reverse of " + strToReverse + " is: " + reversedString);

		}
	}
}
