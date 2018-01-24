using System;
using System.Linq;
using System.Collections.Generic;

namespace OneKeyboardWordCP
{
	public class Solution
	{
		string row1 = "qwertyuiop";
		string row2 = "asdfghjkl";
		string row3 = "zxcvbnm";

		public string[] FindWords(string[] words)
		{
			/// <summary>
			/// Find the words can be completed with one keyboard row from the 
			/// string array argument
			/// 
			/// type words	:	string[]
			/// rtype		:	string[]
			/// </summary>

			// Create a list from the string array argument
			List<string> oneRowWords = new List<string>(words);

			// Loop through words in the string array
			for (int i = 0; i < words.Length; i++)
			{
				Console.WriteLine(words[i]);
				// Check if the word can be written with one keyboard
				if (IsOneRowWord(words[i].ToLower()) == false)
				{
					Console.WriteLine("Removing: " + words[i]);
					oneRowWords.Remove(words[i]);
				}
			}

			return oneRowWords.ToArray();
		}

		public bool IsOneRowWord(string word)
		{
			/// <summary>
			/// Check if word can be completed on one keyboard
			/// 
			/// type word	:	string
			/// rtype		:	bool
			/// </summary>

			// Check if word can be completed on row 1
			for (int i = 0; i < word.Length; i++)
			{
				Console.WriteLine("Testing on row 1, word: " + word);
				// Check if this is not the first char check and if that char DOESN'T belong in the row
				if ((i > 0) && (row1.Contains(word[i]) == false))
				{
					// Since this is not the first char, that means there were chars that were found on
					// this row, now that the rest cannot be found on the same row, it means, this word
					// requires multiple rows to create, so we can return false 
					return false;
				}

				// Check if char is not in row
				if (row1.Contains(word[i]) == false)
				{
					// Move to next row
					break;
				}

				// Check if this is the last char in the word
				if (i == word.Length - 1)
				{
					// Then the word was completed on one row
					return true;
				}
			}

			// Check if word can be completed on row 2
			for (int i = 0; i<word.Length; i++)
			{
				Console.WriteLine("Testing on row 2, word: " + word);
				// Check if this is not the first char check and if that char DOESN'T belong in the row
				if ((i > 0) && (row2.Contains(word[i]) == false))
				{
					// Since this is not the first char, that means there were chars that were found on
					// this row, now that the rest cannot be found on the same row, it means, this word
					// requires multiple rows to create, so we can return false 
					return false;
				}

				// Check if char is not in row
				if (row2.Contains(word[i]) == false)
				{
					// Move to next row
					break;
				}

				// Check if this is the last char in the word
				if (i == word.Length - 1)
				{
					// Then the word was completed on one row
					return true;
				}
			}

			// Check if word can be completed on row 3
			for (int i = 0; i<word.Length; i++)
			{
				Console.WriteLine("Testing on row 3, word: " + word);
				// Check if char is not in row
				if (row3.Contains(word[i]) == false)
				{
					// Move to next row
					break;
				}

				// Check if this is the last char in the word
				if (i == word.Length - 1)
				{
					// Then the word was completed on one row
					return true;
				}
			}

			return false;
		}

	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			// create a reference to the Solution class
			Solution sol = new Solution();

			// Create a test input
			string[] testArr = { "Hello", "Alaska", "Dad", "Peace" };

			// Find the words that can be completed on one row
			string[] ans = sol.FindWords(testArr);
			Console.WriteLine(ans.Length);

			for (int i = 0; i < ans.Length; i++)
			{
				Console.WriteLine("One Row Word: " + ans[i]);
			}
		}
	}
}
