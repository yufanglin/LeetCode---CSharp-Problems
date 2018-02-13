using System;

namespace MergeTwoBinaryTreesCP
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		// Constructor
		public TreeNode(int x) { val = x; }
  
	}
	
	public class Solution
	{
		public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
		{
			/*
			 * Add two nodes values from two different binary trees together
			 * 
			 * type t1	:	TreeNode of tree 1
			 * type t2	:	TreeNode of tree 2
			 * rtype	:	TreeNode
			*/

			// Check if either node is null (parent node is a leaf), if so, return the other node 
			if (t1 == null)
			{
				// this can still be null
				return t2;
			}

			if (t2 == null)
			{
				return t1;
			}

			// Add the values of t1/t2 and set it to t1
			t1.val += t2.val;

			// Recursion: Traverse Left Child of both tree nodes
			t1.left = MergeTrees(t1.left, t2.left);

			// Recursion: Travese Right Child of both three nodes
			t1.right = MergeTrees(t1.right, t2.right);

			// Return the new t1 tree node
			return t1;
		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create an instance of the solution class
			Solution sol = new Solution();

			// create two binary trees

			// merge trees

			// print out result

		}
	}
}
