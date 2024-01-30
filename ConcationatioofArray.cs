
using System;

public class ConcatenateArrays
{
    public static void main(String[] args)
    {
        int[] nums = { 1, 2, 3 };

        // Calculate the length of the resulting array
        int n = nums.length;
        int[] ans = new int[2 * n];

        // Copy elements from nums to ans at the beginning
        System.arraycopy(nums, 0, ans, 0, n);

        // Copy elements from nums to ans after the first set
        System.arraycopy(nums, 0, ans, n, n);

        // Print the result
        System.out.print("Result: ");
        for (int num : ans)
        {
            System.out.print(num + " ");
        }
    }
}
using System;

public class Class1
{
	public Class1()
	{
	}
}
