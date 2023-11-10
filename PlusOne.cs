


//You are given a large integer represented as an integer array digits, where each digits[i] is the 
//	ith digit of the integer. The digits are ordered from most significant to least significant
//	in left-to-right order. The large integer does not contain any leading 0's.

//Increment the large integer by one and return the resulting array of digits.

using System;
using System.Collections.Generic;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length;
        List<int> result = new List<int>();
        int carry = 1; // Initialize the carry to 1 to add 1 to the number

        for (int i = n - 1; i >= 0; i--)
        {
            int sum = digits[i] + carry;
            carry = sum / 10;
            result.Add(sum % 10);
        }

        if (carry > 0)
        {
            result.Add(carry);
        }

        result.Reverse(); // Reverse the list to get the correct order of digits

        return result.ToArray();
    }
}
