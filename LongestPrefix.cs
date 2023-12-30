
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {

        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        // Take the first string as a reference
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            // Find the common prefix by comparing each character
            int j = 0;
            while (j < prefix.Length && j < strs[i].Length && prefix[j] == strs[i][j])
            {
                j++;
            }

            // Update the prefix to the common characters
            prefix = prefix.Substring(0, j);

            // If no common prefix found, return ""
            if (prefix == "")
            {
                return "";
            }
        }

        return prefix;
    }
}
