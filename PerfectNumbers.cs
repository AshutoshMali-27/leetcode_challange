
//A perfect number is a positive integer that is equal to the sum of its positive divisors, excluding the number itself. A divisor of an integer x is an integer that can divide x evenly.

//Given an integer n, return true if n is a perfect number, otherwise return false.
using System;

class Solution
{


    public boolean checkPerfectNumber(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        int sum = 1; // Start with 1 as 1 is always a divisor

        for (int i = 2; i <= Math.sqrt(num); i++)
        {
            if (num % i == 0)
            {
                sum += i;
                if (i != num / i) // Avoid counting the same divisor twice for perfect squares
                {
                    sum += num / i;
                }
            }
        }

        return sum == num;
    }
}
