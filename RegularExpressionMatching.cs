//Regular Expression Matching
//Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:

//'.' Matches any single character.​​​​
//'*' Matches zero or more of the preceding element.
//The matching should cover the entire input string (not partial).



//Example 1:

//Input: s = "aa", p = "a"
//Output: false
//Explanation: "a" does not match the entire string "aa".

public class Solution
{
    public bool IsMatch(string s, string p)
    {
        int m = s.Length;
        int n = p.Length;

        bool[,] dp = new bool[m + 1, n + 1];
        dp[0, 0] = true;

        for (int j = 1; j <= n; j++)
        {
            if (p[j - 1] == '*')
            {
                dp[0, j] = dp[0, j - 2];
            }
        }

        for (int i = 1; i <= m; i++)-
        {
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == s[i - 1] || p[j - 1] == '.')
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else if (p[j - 1] == '*')
                {
                    dp[i, j] = dp[i, j - 2] || (dp[i - 1, j] && (s[i - 1] == p[j - 2] || p[j - 2] == '.'));
                }
            }
        }

        return dp[m, n];
    }
}
