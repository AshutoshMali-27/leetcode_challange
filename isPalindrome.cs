// Given an integer x, return true if x is a palindrome, and false otherwise.

public class Solution
{
    public bool IsPalindrome(int x)
    {

        string str = x.ToString();


        char[] charArray = str.ToCharArray();


        Array.Reverse(charArray);

        string reversedStr = new string(charArray);

        return str == reversedStr;
    }
}
