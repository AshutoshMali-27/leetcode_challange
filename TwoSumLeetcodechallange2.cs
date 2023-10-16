
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.

//Example 1:

//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
//Example 2:

//Input: nums = [3, 2, 4], target = 6
//Output: [1,2]
//Example 3:

//Input: nums = [3, 3], target = 6
//Output: [0,1]
 

//Constraints:

//2 <= nums.length <= 104
//- 109 <= nums[i] <= 109
//- 109 <= target <= 109
//Only one valid answer exists.


using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numToIndex.ContainsKey(complement))
            {
                // Found a pair that adds up to the target
                return new int[] { numToIndex[complement], i };
            }

            if (!numToIndex.ContainsKey(nums[i]))
            {
                // Add the current number to the dictionary if not already present
                numToIndex[nums[i]] = i;
            }
        }

        // No solution found
        return new int[] { -1, -1 };
    }
}
