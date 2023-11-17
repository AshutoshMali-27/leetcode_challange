//Given an integer array nums, return true if any value appears at least twice in the array,
//    and return false if every element is distinct.

//Example 1:

//Input: nums = [1, 2, 3, 1]
//Output: true
//Example 2:

//Input: nums = [1, 2, 3, 4]
//Output: false
//Example 3:

//Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
//Output: true




using System.Collections.Generic;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                if (!set.Add(num))
                {
                    // If the element is already present in the set, it's a duplicate
                    return true;
                }
            }

            // No duplicates found
            return false;
        }
    }
}