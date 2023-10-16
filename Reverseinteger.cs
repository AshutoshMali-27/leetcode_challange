



//Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

//Assume the environment does not allow you to store 64-bit integers (signed or unsigned).



public class Solution
{
    public int Reverse(int x)
    {


        int reversed = 0;

        while (x != 0)
        {
            int lastDigit = x % 10;
            x /= 10;

            // Check for integer overflow/underflow
            if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && lastDigit > 7))
            {
                return 0;
            }
            if (reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && lastDigit < -8))
            {
                return 0;
            }

            reversed = reversed * 10 + lastDigit;
        }

        return reversed;

    }
}