
using System.Collections.Generic;

Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
using System;

public class Class1
{
	public Class1()public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {

            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numIndices.ContainsKey(nums[i]) && i - numIndices[nums[i]] <= k)
                {
                    return true;
                }

                numIndices[nums[i]] = i;
            }

            return false;
        }
    }
	{
	}
}
