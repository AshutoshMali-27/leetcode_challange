//Given two binary strings a and b, return their sum as a binary string.

//Example 1:

//Input: a = "11", b = "1"
//Output: "100"
//Example 2:

//Input: a = "1010", b = "1011"
//Output: "10101"

//Constraints:

//1 <= a.length, b.length <= 104
//a and b consist only of '0' or '1' characters.
//Each string does not contain leading zeros except for the zero itself.

public class Solution
{
    public string AddBinary(string a, string b)
    {
        int carry = 0;
        int i = a.Length - 1;
        int j = b.Length - 1;
        var result = new System.Text.StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;

            if (i >= 0)
            {
                sum += a[i] - '0';
                i--;
            }
            if (j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }

            carry = sum / 2;
            result.Insert(0, sum % 2);
        }

        return result.ToString();
    }
}