using System;

namespace TrimBinarySearchTreeCP
{
 	public class TreeNode {
		/*
         * Definition for a binary tree node.
        */
     	public int val;
    	public TreeNode left;
     	public TreeNode right;
     	public TreeNode(int x) { val = x; }

 	}

	public class Solution
	{
		public TreeNode TrimBST(TreeNode root, int L, int R)
		{
			/*
			 * trim tree so each node's value is between R >= L
			*/

			// Check if there is a root
			if (root == null)
			{
				// no root, either previous root was a leaf, or the tree has no nodes
				return null;
			}

			// Check if the the root's value is larger than R (root supposed to be smaller than or equal to the upper bound)
			if (root.val > R)
			{
				// Traverse the tree with a the left child as the root, since the left child's value < root.val
				return TrimBST(root.left, L, R);
			}

			// Check if the root's value is smaller than L (root supposed to be larger than or equal to the lower bound)
			if (root.val < L)
			{
				// Traverse tree with the right child as the root, since the right child's value > root.val
				return TrimBST(root.right, L, R);
			}


			// Found a root whose value is within the R >= L bounds
			// Set the root's left child 
			root.left = TrimBST(root.left, L, R);
			// Set the root's right child
			root.right = TrimBST(root.right, L, R);

			// Return the root, whose value should be in bounds
			return root;

		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create a solution instance
			Solution sol = new Solution();


		}
	}
}
