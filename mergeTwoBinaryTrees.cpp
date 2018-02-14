#include <iostream>		// for cout, cin, etc

using namespace std;

struct TreeNode {
	int val;
	TreeNode *left;
	TreeNode *right;
	TreeNode(int x) : val(x), left(NULL), right(NULL) {}
};


class Solution {
public:
	TreeNode* mergeTrees(TreeNode* t1, TreeNode* t2) {
		/*
		 * Add the values of two trees 
		 * type	t1:	TreeNode
		 * type t2: TreeNode
		 * rtype  : TreeNode
		*/

		// If t1 is null, return t2 to set the new tree's merge value as t2
		if (t1 == NULL) {
			return t2;
		}

		// If t2 is null, return t1 to set the new tree's merge value as t1
		if (t2 == NULL) {
			return t1;
		}

		// Neither values are null, add two values to t1's
		t1->val += t2->val;

		// Left child of both nodes
		t1->left = mergeTrees(t1->left, t2->left);

		// Right child of both nodes
		t1->right = mergeTrees(t1->right, t2->right);

		// Return the new t1 node
		return t1;
	}
};


int main() {

	// Create an instance of Solution
	Solution *sol = new Solution();

	// Create two trees

	// merge trees

	return 0;
}