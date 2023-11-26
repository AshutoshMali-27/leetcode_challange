﻿

//Given an integer array nums where the elements are sorted in ascending order, convert it to a 
//height-balanced
// binary search tree.


public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return null;
        }

        return SortedArrayToBST(nums, 0, nums.Length - 1);
    }

    private TreeNode SortedArrayToBST(int[] nums, int left, int right)
    {
        if (left > right)
        {
            return null;
        }

        int mid = left + (right - left) / 2;

        TreeNode root = new TreeNode(nums[mid]);

        root.left = SortedArrayToBST(nums, left, mid - 1);
        root.right = SortedArrayToBST(nums, mid + 1, right);

        return root;
    }
}