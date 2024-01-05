//Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.
//Input: num = 38
//Output: 2
//Explanation: The process is
//38-- > 3 + 8-- > 11
//11-- > 1 + 1-- > 2
//Since 2 has only one digit, return it.

public class Solution
{
    public int AddDigits(int num)
    {
        while (num >= 10)
        {
            int sumDigits = 0;
            while (num > 0)
            {
                sumDigits += num % 10;
                num /= 10;
            }

            num = sumDigits;
        }
        return num;
    }
}
