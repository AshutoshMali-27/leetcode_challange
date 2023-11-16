

//Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

//You must implement a solution with a linear runtime complexity and use only constant extra space.


using System;

class Program
{
    static void Main()
    {
        int[] nums = { 4, 2, 1, 2, 1 };
        int result = SingleNumber(nums);
        Console.WriteLine($"The single number is: {result}");
    }

    static int SingleNumber(int[] nums)
    {
        int result = 0;

        foreach (int num in nums)
        {
            result ^= num;
        }

        return result;
    }
}
