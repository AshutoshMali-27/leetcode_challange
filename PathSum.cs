
//Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.

//A leaf is a node with no children.




public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }

        // Check if it's a leaf node and the target sum is reached
        if (root.left == null && root.right == null && targetSum - root.val == 0)
        {
            return true;
        }

        // Recursively check the left and right subtrees
        return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
    }
}