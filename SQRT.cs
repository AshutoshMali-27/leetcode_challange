Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

You must not use any built-in exponent function or operator.

For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.


    public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 0)
        {
            return 0;
        }

        long left = 1;
        long right = x;
        long result = 0;

        while (left <= right)
        {
            long mid = left + (right - left) / 2;
            long square = mid * mid;

            if (square == x)
            {
                return (int)mid;
            }
            else if (square < x)
            {
                left = mid + 1;
                result = mid; // Update the result while searching for the integer square root.
            }
            else
            {
                right = mid - 1;
            }
        }

        return (int)result;
    }
}
