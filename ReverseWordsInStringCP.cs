using System;

namespace ReverseWordsInStringCP
{
	class MainClass
	{
		public class Solution 
		{
			public string ReverseWords(string s) {
				/*
				 * This method reverses the words in a string
				 * 
				 * type	s	:	string
				 * rtype	:	string
				 * 
				 */

				// Split the string into an array of words
				string[] words = s.Split(' ');

				// Loop through the words and reverse each one
				for (int i = 0; i < words.Length; i++) 
				{
					words[i] = ReverseTheWords(words[i]);
				}

				// rejoin the words in the array and return the string
				return string.Join(" ", words);
			}

			public string ReverseTheWords(string s) {
				/*
				 * This method reverses a string
				 * 
				 * type s	:	string
				 * rtype	:	string
				 * 
				 */

				// change string to an array of char
				char[] charArray = s.ToCharArray();
				Array.Reverse(charArray);

				// reverse array, then return after changing back to a string
				return new String(charArray);
			}
		}
		public static void Main(string[] args)
		{
			// Create an instance of the Solution class
			Solution sol = new Solution();

			// Ask the user for input
			Console.Write("Please enter a string: ");

			// Get user input
			string s = Console.ReadLine();

			// Get the reversed words 
			string reversedWords = sol.ReverseWords(s);

			// print out the string with reversed words
			Console.WriteLine("Reversed words ver: " + reversedWords);
		}
	}
}
