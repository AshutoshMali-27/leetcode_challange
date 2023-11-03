

//Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.

//The integer division should truncate toward zero, which means losing its fractional part. For example, 8.345 would be truncated to 8, and -2.7335 would be truncated to -2.

//Return the quotient after dividing dividend by divisor.

//Note: Assume we are dealing with an environment that could only store integers within the 32-bit signed integer range: [−231, 231 − 1]. For this problem, if the quotient is strictly greater than 231 - 1, then return 231 - 1, and if the quotient is strictly less than -231, then return -231.








using System;

public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        // Handle special cases where the result is out of the specified range.
        if (dividend == Int32.MinValue && divisor == -1)
            return Int32.MaxValue;

        // Determine the sign of the result.
        int sign = (dividend < 0) ^ (divisor < 0) ? -1 : 1;

        // Take the absolute values of dividend and divisor.
        long ldividend = Math.Abs((long)dividend);
        long ldivisor = Math.Abs((long)divisor);

        long quotient = 0;

        // Repeatedly subtract the divisor from the dividend until it's no longer possible.
        while (ldividend >= ldivisor)
        {
            long temp = ldivisor;
            long multiple = 1;

            // Find the largest multiple of the divisor that can be subtracted from the dividend.
            while (ldividend >= (temp << 1))
            {
                temp <<= 1;
                multiple <<= 1;
            }

            // Subtract the multiple of the divisor from the dividend.
            ldividend -= temp;
            quotient += multiple;
        }

        return (int)(sign * quotient);
    }

}
