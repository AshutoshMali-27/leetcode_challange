
//Longest Palindromic Substring

//Given a string s, return the longest 
//palindromic

//substring
// in s.



//Example 1:

//Input: s = "babad"
//Output: "bab"
//Explanation: "aba" is also a valid answer.
//Example 2:

//Input: s = "cbbd"
//Output: "bb"

public class Solution
{
    public string LongestPalindrome(string s)
    {

        if (string.IsNullOrEmpty(s))
        {
            return "";
        }

        int n = s.Length;
        bool[,] isPalindrome = new bool[n, n];

        // All substrings of length 1 are palindromes
        for (int i = 0; i < n; i++)
        {
            isPalindrome[i, i] = true;
        }

        int start = 0;
        int maxLength = 1;

        // Check substrings of length 2
        for (int i = 0; i < n - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                isPalindrome[i, i + 1] = true;
                start = i;
                maxLength = 2;
            }
        }

        // Check substrings of length 3 or more
        for (int k = 3; k <= n; k++)
        {
            for (int i = 0; i < n - k + 1; i++)
            {
                int j = i + k - 1;

                if (isPalindrome[i + 1, j - 1] && s[i] == s[j])
                {
                    isPalindrome[i, j] = true;

                    if (k > maxLength)
                    {
                        start = i;
                        maxLength = k;
                    }
                }
            }
        }

        return s.Substring(start, maxLength);
    }

}
